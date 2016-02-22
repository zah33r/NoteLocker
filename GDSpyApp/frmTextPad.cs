using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;
using System.Threading;
using System.IO;

namespace NoteLocker
{
    public partial class frmTextPad : Form
    {
        #region Local Variables

        private System.Timers.Timer signInTimeOut = new System.Timers.Timer();
        public System.Timers.Timer autoSaveTimer = new System.Timers.Timer();
        bool newTabAdded = false;
        bool isStreched = false;
        private bool isMinimizeToTray = false;
        int userControlID = 0;
        Label selectedLabel = null;

        #endregion Local Variables

        #region Ctor

        public frmTextPad()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                (new frmConfigurations(this)).ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        private void lblSetTopic_Click(object sender, EventArgs e)
        {
            try
            {
                txtTopic.Focus();
            }
            catch (Exception)
            {
            }
        }

        private void toolStripMenuItemSaveFile_Click(object sender, EventArgs e)
        {
            saveToCloud();
        }

        private void saveToCloud()
        {
            this.Cursor = Cursors.WaitCursor;
            this.Text += " - Uploading to google drive - Please wait...";
            System.Collections.Hashtable localTable = new System.Collections.Hashtable();

            try
            {
                SaveSelectedTabState();
            }
            catch (Exception)
            {
                throw;
            }

            try
            {
                List<int> listOfKeys = hashTableTabCollection.Keys.Cast<int>().ToList();

                for (int counter = 0; counter < listOfKeys.Count; counter++)
                {
                    int key = (int)listOfKeys[counter];
                    DocumentTab value = (DocumentTab)hashTableTabCollection[key];
                    Google.Apis.Drive.v2.Data.File currentJobFile = null;
                    System.IO.MemoryStream stream;
                    stream = new System.IO.MemoryStream(Encoding.Default.GetBytes(value.content));

                    if (value.currentJobFile != null)
                    {
                        if (value.title.Trim() != string.Empty)
                            currentJobFile = DriveCommand.updateFile(value.currentJobFile.Id, value.title.Trim(), stream, value.currentJobFile.OriginalFilename, true);
                        else
                            currentJobFile = DriveCommand.updateFile(value.currentJobFile.Id, value.currentJobFile.Title, stream, value.currentJobFile.OriginalFilename, true);
                    }
                    else
                    {
                        if (validateDocument(value))
                        {
                            DriveCommand.createFile(value.title.Trim(), stream, out currentJobFile);

                            localTable.Add(key, currentJobFile);
                        }
                        else
                        {
                            string TopicName = value.textContent.Trim();

                            if (TopicName.Length > 10)
                            {
                                TopicName = TopicName.Substring(0, 10);
                                DriveCommand.createFile(TopicName, stream, out currentJobFile);

                                localTable.Add(key, currentJobFile);
                            }
                            else
                            {
                                MessageBox.Show("Please enter 10 or more characters to save the document when title is not provided.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }

                foreach (int key in localTable.Keys)
                {
                    if (hashTableTabCollection.ContainsKey(key))
                    {
                        DocumentTab dTab = (DocumentTab)hashTableTabCollection[key];
                        dTab.currentJobFile = (Google.Apis.Drive.v2.Data.File)localTable[key];
                        hashTableTabCollection[key] = dTab;
                    }
                }
            }
            catch (Exception)
            {
            }

            #region Single File Code
            //try
            //{
            //    System.IO.MemoryStream stream;
            //    stream = new System.IO.MemoryStream(Encoding.Default.GetBytes(txtDocument.Rtf));


            //    if (DriveCommand.currentJobFile != null)
            //    {
            //        if (txtTopic.Text.Trim() != string.Empty)
            //            DriveCommand.updateFile(DriveCommand.currentJobFile.Id, txtTopic.Text.Trim(), stream, DriveCommand.currentJobFile.OriginalFilename, true);
            //        else
            //            DriveCommand.updateFile(DriveCommand.currentJobFile.Id, DriveCommand.currentJobFile.Title, stream, DriveCommand.currentJobFile.OriginalFilename, true);
            //    }
            //    else
            //    {
            //        if (validateDocument())
            //            DriveCommand.createFile(txtTopic.Text.Trim(), stream);
            //        else
            //        {
            //            string TopicName = txtDocument.Text.TrimStart();

            //            if (TopicName.Length > 10)
            //            {
            //                TopicName = TopicName.Substring(0, 10);
            //                DriveCommand.createFile(TopicName, stream);
            //            }
            //            else
            //            {
            //                MessageBox.Show("Please enter 10 or more characters to save the document when title is not provided.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //}
            #endregion

            this.Text = this.Text.Replace(" - Uploading to google drive - Please wait...", string.Empty);
            this.Cursor = Cursors.Arrow;
        }

        void txtDocument_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            try
            {
                if ((e.Data.GetDataPresent(DataFormats.FileDrop)))
                {
                    e.Effect = DragDropEffects.Copy;
                }
            }
            catch (Exception)
            {
            }
        }

        void txtDocument_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            try
            {
                Image img = default(Image);
                img = Image.FromFile(((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString());
                Clipboard.SetImage(img);

                this.txtDocument.SelectionStart = 0;
                this.txtDocument.Paste();
            }
            catch (Exception)
            {
            }
        }

        private void frmTextPad_Load(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanel.HorizontalScroll.Enabled = false;
                flowLayoutPanel.VerticalScroll.Enabled = true;

                this.AllowDrop = true;
                this.txtDocument.DragEnter += new DragEventHandler(txtDocument_DragEnter);
                this.txtDocument.DragDrop += new DragEventHandler(txtDocument_DragDrop);

                System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;

                if (!Directory.Exists(Path.Combine(Application.StartupPath, "Documents")))
                    Directory.CreateDirectory(Path.Combine(Application.StartupPath, "Documents"));

                initTabUIforNewTab();
                label_Click(selectedLabel, null);

                loadAppSettings();
                initSignInTimer();
                DriveCommand.initGoogleService();
                initAutoSaveTimer();
            }
            catch (Exception)
            {
            }
        }

        private bool validateDocument()
        {
            try
            {
                if (txtTopic.Text.Trim() != string.Empty)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool validateDocument(DocumentTab item)
        {
            try
            {
                if (item.title.Trim() != string.Empty)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void toolStripMenuIRemoveAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (DriveCommand.removeUserCredentials())
                {
                    MessageBox.Show("Google Account removed successfully. Application will now restart and will ask for new login credentials.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
            }
            catch (Exception)
            {
            }
        }

        public void autoSaveTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                autoSaveTimer.Stop();

                SaveSelectedTabState();

                DocumentTab dTab = (DocumentTab)hashTableTabCollection[selectedLabel.Tag];
                txtDocument.Rtf = dTab.content;
                txtTopic.Text = dTab.title;
                txtDocument.BackColor = dTab.backgroundColor;
                txtDocument.Font = dTab.font;
                txtDocument.ForeColor = dTab.textColor;
                toolStripMenuItemWrap.Checked = dTab.wordWrap;
                txtDocument.ZoomFactor = dTab.ZoomFactor;
                zoomBar.Value = Convert.ToInt32(dTab.ZoomFactor);

                deleteLeftOverTabs();
                SaveSelectedTabState();

                if (DriveSettings.isLocalSaveOn)
                    SaveToLocalDrive();

                if (DriveSettings.isRemoteSaveOn)
                    saveToCloud();
            }
            catch (Exception)
            {
            }
            finally
            {
                autoSaveTimer.Start();
            }
        }

        private void SaveToLocalDrive()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                this.Text += " - Saving in local directory - Please wait...";

                foreach (DocumentTab item in hashTableTabCollection.Values)
                {
                    byte[] byteArray = System.Text.Encoding.Default.GetBytes(item.content);
                    string outputFile = string.Empty;

                    if (item.title.Trim() != string.Empty)
                    {
                        outputFile = System.IO.Path.Combine(DriveSettings.autoSaveLocation, item.title + ".rtf");
                    }
                    else
                    {
                        if (item.textContent.Length > 10)
                        {
                            string filename = item.textContent.Substring(0, 10);
                            outputFile = System.IO.Path.Combine(DriveSettings.autoSaveLocation, filename + ".rtf");
                        }
                        else if (item.textContent.Trim().Length > 0)
                        {
                            string filename = item.textContent.Trim();
                            outputFile = System.IO.Path.Combine(DriveSettings.autoSaveLocation, filename + ".rtf");
                        }
                        else
                        {
                            continue;
                            //nothing to save
                        }
                    }

                    try
                    {
                        System.IO.File.WriteAllBytes(outputFile, byteArray);
                        //MessageBox.Show("File saved at: " + outputFile, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An error occured while trying to save file to location: " + outputFile + Environment.NewLine + "Please check filename for special characters and try again.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                //byte[] byteArray = System.Text.Encoding.Unicode.GetBytes(txtDocument.Text);
                //string outputFile = System.IO.Path.Combine(Application.StartupPath, "Documents", txtTopic.Text.Trim() + ".txt");
                //System.IO.File.WriteAllBytes(outputFile, byteArray);
                //MessageBox.Show("File saved at: " + saveFileDialog.FileName, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
            }
            finally
            {
                this.Text = this.Text.Replace(" - Saving in local directory - Please wait...", string.Empty);
                this.Cursor = Cursors.Arrow;
            }
        }

        [Obsolete("Validations is now done in SaveToLocalFile function", true)]
        private bool validateLocalSave()
        {
            try
            {
                if (txtTopic.Text.Trim() != string.Empty && txtDocument.Text.Trim() != string.Empty)
                    return true;

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void signInTimeOut_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                if (DriveCommand.credential == null)
                {
                    signInTimeOut.Enabled = false;
                    signInTimeOut.Elapsed -= new System.Timers.ElapsedEventHandler(signInTimeOut_Elapsed);
                    MessageBox.Show("Timeout period elapsed, prior to connect to Google Services." + System.Environment.NewLine + System.Environment.NewLine + "Error Message: Unable to connect to Google Drive." + System.Environment.NewLine + "Application will now abort. Please check your internet connection and try again later.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Process currentApp = Process.GetCurrentProcess();
                    currentApp.Kill();  //Had to kill the process as the thread executed by Google Web service remains idle and dont allow application to close gracefully.
                }
            }
            catch (Exception)
            {
            }
        }

        private bool initAutoSaveTimer()
        {
            try
            {
                autoSaveTimer.Interval = DriveSettings.autoSaveInterval * 60 * 1000;
                autoSaveTimer.Elapsed += new System.Timers.ElapsedEventHandler(autoSaveTimer_Elapsed);
                autoSaveTimer.Enabled = true;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool initSignInTimer()
        {
            try
            {
                signInTimeOut.Interval = DriveSettings.signInTimeOut * 1000;
                signInTimeOut.Elapsed += new System.Timers.ElapsedEventHandler(signInTimeOut_Elapsed);
                signInTimeOut.Enabled = true;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool loadAppSettings()
        {
            try
            {
                Int32.TryParse(ConfigurationManager.AppSettings["autoSaveInterval"], out DriveSettings.autoSaveInterval);
                bool.TryParse(ConfigurationManager.AppSettings["isLocalSaveOn"], out DriveSettings.isLocalSaveOn);
                bool.TryParse(ConfigurationManager.AppSettings["isRemoteSaveOn"], out DriveSettings.isRemoteSaveOn);
                Int32.TryParse(ConfigurationManager.AppSettings["signInTimeOut"], out DriveSettings.signInTimeOut);
                DriveSettings.autoSaveLocation = ConfigurationManager.AppSettings["autoSaveDirectory"].ToString();

                DriveSettings.clientId = Convert.ToString(ConfigurationManager.AppSettings["clientId"]);
                DriveSettings.clientSecret = Convert.ToString(ConfigurationManager.AppSettings["clientSecret"]);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void toolStripMenuItemSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog.Filter = "Text file (*.txt)|*.txt|Rich text file (*.rtf)|*.rtf|Microsoft Office document file (*.docx)|*.docx";
                saveFileDialog.Title = "Please enter file name without file extension";

                if (DialogResult.OK == saveFileDialog.ShowDialog())
                {
                    if (System.IO.File.Exists(saveFileDialog.FileName))
                        System.IO.File.Delete(saveFileDialog.FileName);

                    if (saveFileDialog.FilterIndex == 0)
                    {
                        byte[] byteArray = System.Text.Encoding.Unicode.GetBytes(txtDocument.Text);
                        System.IO.File.WriteAllBytes(saveFileDialog.FileName + ".txt", byteArray);
                    }
                    else if (saveFileDialog.FilterIndex == 1)
                    {
                        txtDocument.SaveFile(saveFileDialog.FileName + ".rtf");
                    }
                    else
                    {
                        string tempFile = Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData) + "\\manSave.rtf";
                        txtDocument.SaveFile(tempFile);

                        try
                        {
                            var wordApp = new Microsoft.Office.Interop.Word.Application();
                            var currentDoc = wordApp.Documents.Open(tempFile);
                            currentDoc.SaveAs(saveFileDialog.FileName, Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatDocumentDefault);
                            currentDoc.Close();
                            wordApp.Quit();
                        }
                        catch (Exception InnerExc)
                        {

                        }
                        finally
                        {
                            if (File.Exists(tempFile))
                                File.Delete(tempFile);
                        }
                    }

                    MessageBox.Show("File saved at: " + saveFileDialog.FileName, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtTopic_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTopic.Text.Trim() != string.Empty)
                {
                    toolStripStatusLabelDocumentTitle.Text = txtTopic.Text;

                    if (toolStripStatusLabelDocumentTitle.Text.Trim().Length > 10)
                        selectedLabel.Text = toolStripStatusLabelDocumentTitle.Text.Trim().Remove(10);
                    else
                        selectedLabel.Text = toolStripStatusLabelDocumentTitle.Text.Trim();
                }
                else
                {
                    if (newTabAdded)
                    {
                        toolStripStatusLabelDocumentTitle.Text = "[ Document Title ]";
                        newTabAdded = false;
                        return;
                    }

                    selectedLabel.Text = "Document Title";
                    toolStripStatusLabelDocumentTitle.Text = "[ Document Title ]";
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtDocument_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control && e.KeyCode == Keys.S)
                    toolStripMenuItemSaveFile_Click(null, null);
            }
            catch (Exception)
            {
            }
        }

        private void txtDocument_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] totalWordsInDocument = txtDocument.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                toolStripStatusLabelWordCount.Text = totalWordsInDocument.LongCount().ToString();
            }
            catch (Exception)
            {
            }
        }

        private void textColorSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == this.colorPicker.ShowDialog())
                txtDocument.ForeColor = this.colorPicker.Color;
        }

        private void backgroundColorToolStripMenuItemBackColor_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == this.colorPicker.ShowDialog())
                txtDocument.BackColor = this.colorPicker.Color;
        }

        private void txtDocument_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDocument.SelectedText.Length > 0)
                {
                    string[] totalWordsInDocument = txtDocument.SelectedText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    toolStripStatusLabelWordCount.Text = totalWordsInDocument.LongCount().ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void fontsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.OK == documentFont.ShowDialog())
                {
                    txtDocument.Font = documentFont.Font;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void toolStripMenuItemWrap_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripMenuItemWrap.Checked = txtDocument.WordWrap = !toolStripMenuItemWrap.Checked;
            }
            catch (Exception)
            {
            }
        }

        private void toolStripStatusZoom_Click(object sender, EventArgs e)
        {
            try
            {
                zoomBar.Visible = !zoomBar.Visible;
                zoomBar.Focus();
            }
            catch (Exception)
            {
            }
        }

        private void zoomBar_Leave(object sender, EventArgs e)
        {
            zoomBar.Visible = false;
        }

        private void zoomBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                txtDocument.ZoomFactor = zoomBar.Value;
            }
            catch (Exception)
            {
            }
        }

        private void toolStripMenuItemNewTab_Click(object sender, EventArgs e)
        {
            try
            {
                newTabAdded = true;
                SaveSelectedTabState();
                initTabUIforNewTab();
                deleteLeftOverTabs();
            }
            catch (Exception)
            {
                throw;
            }
        }

        System.Collections.Hashtable hashTableTabCollection = new System.Collections.Hashtable();
        
        private void initTabUIforNewTab()
        {
            try
            {
                DeSelectAllLabels();

                Label label = new Label();
                label.Text = "Document Title";
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.BackColor = Color.Transparent;
                label.ForeColor = Color.White;
                label.AutoSize = false;
                label.Width = 140;
                label.Height = 35;
                label.Cursor = Cursors.Arrow;
                label.Image = Image.FromFile(Application.StartupPath + @"\Images\focused.png");
                label.Tag = userControlID;
                userControlID++;

                flowLayoutPanel.Controls.Add(label);
                label.RightToLeft = RightToLeft.No;

                DocumentTab dTab = new DocumentTab();
                txtTopic.Text = txtDocument.Text = string.Empty;
                dTab.content = txtDocument.Rtf;
                dTab.textContent = txtDocument.Text;
                dTab.title = txtTopic.Text.Trim();

                hashTableTabCollection.Add(label.Tag, dTab);

                label.ContextMenuStrip = contextMenuTabPage;

                label.Controls.Add(initDeleteButtonForTabHeaders(label));
                label.Click += new EventHandler(label_Click);
                selectedLabel = label;
            }
            catch (Exception)
            {

                throw;
            }
        }

        Label initDeleteButtonForTabHeaders(Label label)
        {
            Label deleteLabel = new Label();

            try
            {
                //deleteLabel.Text = "X";
                deleteLabel.TextAlign = ContentAlignment.MiddleCenter;
                deleteLabel.BackColor = Color.Transparent;
                deleteLabel.ForeColor = Color.Transparent;
                deleteLabel.AutoSize = false;
                deleteLabel.Width = 20;
                deleteLabel.Height = 20;
                deleteLabel.Cursor = Cursors.Hand;
                deleteLabel.BorderStyle = BorderStyle.None;
                deleteLabel.Tag = userControlID;
                deleteLabel.Location = new Point(label.Width - deleteLabel.Width - 3, 7);
                deleteLabel.Click += new EventHandler(deleteLabel_Click);
            }
            catch (Exception)
            {
                return deleteLabel;
            }

            return deleteLabel;
        }

        void deleteLabel_Click(object sender, EventArgs e)
        {
            try
            {
                deleteLeftOverTabs();
                closeByDeleteButton(sender as Label);
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        void label_Click(object sender, EventArgs e)
        {
            try
            {
                SaveSelectedTabState();
                DeSelectAllLabels();

                selectedLabel = sender as Label;
                int ID = Convert.ToInt32(selectedLabel.Tag);

                DocumentTab dTab = (DocumentTab)hashTableTabCollection[ID];
                txtDocument.Rtf = dTab.content;
                txtTopic.Text = dTab.title;
                txtDocument.BackColor = dTab.backgroundColor;
                txtDocument.Font = dTab.font;
                txtDocument.ForeColor = dTab.textColor;
                toolStripMenuItemWrap.Checked = dTab.wordWrap;
                txtDocument.ZoomFactor = dTab.ZoomFactor;
                zoomBar.Value = Convert.ToInt32(dTab.ZoomFactor);

                //selectedLabel.BackColor = Color.White;
                //selectedLabel.ForeColor = Color.DimGray;
                selectedLabel.Image = Image.FromFile(Application.StartupPath + @"\Images\focused.png");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DeSelectAllLabels()
        {
            try
            {
                foreach (Control lbl in flowLayoutPanel.Controls)
                {
                    Label fixedLabel = lbl as Label;
                    fixedLabel.Image = Image.FromFile(Application.StartupPath + @"\Images\nfocused.png");
                    //fixedLabel.BackColor = Color.DimGray;
                    //fixedLabel.ForeColor = Color.White;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void toolStripMenuINewWindow_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Application.StartupPath + "\\Note Locker.exe");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                txtDocument.SelectAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                txtDocument.Undo();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage() || Clipboard.ContainsText())
            {
                List<object> ClipboardData = new List<object>();
                List<string> ClipboardDataTypes = new List<string>();

                IDataObject dataObject = Clipboard.GetDataObject();
                string[] formats = dataObject.GetFormats();

                foreach (string format in formats)
                {
                    ClipboardData.Add(dataObject.GetData(format));
                    ClipboardDataTypes.Add(format);
                }

                txtDocument.Cut();

                for (int i = 0; i < ClipboardData.Count; i++)
                {
                    Clipboard.SetData(ClipboardDataTypes[i], ClipboardData[i]);
                }
            }
            else
            {
                txtDocument.Cut();

                if (Clipboard.ContainsText())
                    Clipboard.Clear();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                txtDocument.Cut();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                txtDocument.Copy();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                txtDocument.Paste();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void findAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmFindInDoc.GetInstance(this).Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void goToLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //SetCaretLine(10);
                (new frmGoTo(this)).ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SetCaretLine(int linenr)
        {
            if (linenr > this.txtDocument.Lines.Length)
            {
                MessageBox.Show("Line " + linenr + " is out of range.");
                return;
            }

            int row = 1;
            int charCount = 0;
            foreach (string line in txtDocument.Lines)
            {
                charCount += line.Length + 1;
                row++;
                if (row == linenr)
                {
                    //set the caret here
                    this.txtDocument.SelectionStart = charCount;
                    break;
                }
            }
        }

        private void frmTextPad_Resize(object sender, EventArgs e)
        {
            try
            {
                if (WindowState != FormWindowState.Minimized)
                    flowLayoutPanel_ControlAdded(null, null);

                if (WindowState == FormWindowState.Minimized && isMinimizeToTray)
                {
                    this.Hide();
                }
                else
                {
                    isMinimizeToTray = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                notificationIcon_DoubleClick(null, null);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                new frmConfigurations(this).ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmAbout().ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SaveSelectedTabState()
        {
            try
            {
                DocumentTab dTab = null;

                if (!hashTableTabCollection.ContainsKey(selectedLabel.Tag))
                    dTab = new DocumentTab();
                else
                    dTab = (DocumentTab)hashTableTabCollection[selectedLabel.Tag];

                dTab.content = txtDocument.Rtf;
                dTab.textContent = txtDocument.Text;
                dTab.title = txtTopic.Text.Trim();

                dTab.backgroundColor = txtDocument.BackColor;
                dTab.font = txtDocument.Font;
                dTab.textColor = txtDocument.ForeColor;
                dTab.wordWrap = toolStripMenuItemWrap.Checked;
                dTab.ZoomFactor = txtDocument.ZoomFactor;

                hashTableTabCollection[selectedLabel.Tag] = dTab;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                deleteLeftOverTabs();
                closeSelectedTab();
            }
            catch (Exception Exp)
            {
                string error = Exp.Message;
            }
        }

        private void closeByDeleteButton(Label sender)
        {
            if (sender == null)
                return;

            try
            {
                selectedLabel = sender.Parent as Label;

                if (flowLayoutPanel.Controls.Count == 1)
                {
                    txtDocument.Clear();
                    txtTopic.Text = string.Empty;
                    txtDocument.BackColor = Color.White;
                    txtDocument.ForeColor = Color.Black;
                    toolStripMenuItemWrap.Checked = false;
                    txtDocument.ZoomFactor = 1;
                    zoomBar.Value = Convert.ToInt32(txtDocument.ZoomFactor);

                    DocumentTab dTab_ = (DocumentTab)hashTableTabCollection[Convert.ToInt32(selectedLabel.Tag)];
                    dTab_.textContent = txtDocument.Text;
                    dTab_.title = txtTopic.Text;
                    dTab_.content = txtDocument.Rtf;
                    dTab_.backgroundColor = txtDocument.BackColor;
                    dTab_.textColor = txtDocument.ForeColor;
                    dTab_.wordWrap = false;
                    dTab_.ZoomFactor = txtDocument.ZoomFactor;
                    dTab_.currentJobFile = null;

                    hashTableTabCollection[Convert.ToInt32(selectedLabel.Tag)] = dTab_;

                    return;
                }

                DeSelectAllLabels();

                int counter;
                int selectedTabIndex = -1;
                for (counter = 0; counter < flowLayoutPanel.Controls.Count; counter++)
                {
                    if (flowLayoutPanel.Controls[counter] == selectedLabel)
                    {
                        hashTableTabCollection.Remove(Convert.ToInt32(selectedLabel.Tag));

                        if (counter < flowLayoutPanel.Controls.Count - 1)
                        {
                            selectedTabIndex = Convert.ToInt32(flowLayoutPanel.Controls[counter + 1].Tag);

                            //flowLayoutPanel.Controls[counter + 1].BackColor = Color.White;
                            //flowLayoutPanel.Controls[counter + 1].ForeColor = Color.DimGray;
                            ((Label)flowLayoutPanel.Controls[counter + 1]).Image = Image.FromFile(Application.StartupPath + @"\Images\focused.png");
                        }
                        else if (counter == flowLayoutPanel.Controls.Count - 1)
                        {
                            selectedTabIndex = Convert.ToInt32(flowLayoutPanel.Controls[counter - 1].Tag);

                            ((Label)flowLayoutPanel.Controls[counter - 1]).Image = Image.FromFile(Application.StartupPath + @"\Images\focused.png");
                            //flowLayoutPanel.Controls[counter - 1].BackColor = Color.White;
                            //flowLayoutPanel.Controls[counter - 1].ForeColor = Color.DimGray;
                        }
                        break;
                    }
                }

                if (selectedTabIndex != -1)
                {
                    DocumentTab dTab = (DocumentTab)hashTableTabCollection[selectedTabIndex];
                    txtDocument.Rtf = dTab.content;
                    txtTopic.Text = dTab.title;
                    txtDocument.BackColor = dTab.backgroundColor;
                    txtDocument.Font = dTab.font;
                    txtDocument.ForeColor = dTab.textColor;
                    toolStripMenuItemWrap.Checked = dTab.wordWrap;
                    txtDocument.ZoomFactor = dTab.ZoomFactor;
                    zoomBar.Value = Convert.ToInt32(dTab.ZoomFactor);

                    flowLayoutPanel.Controls.Remove(selectedLabel);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                deleteLeftOverTabs();
            }
        }

        private void closeSelectedTab()
        {
            try
            {
                if (flowLayoutPanel.Controls.Count == 1)
                {
                    txtDocument.Clear();
                    txtTopic.Text = string.Empty;
                    txtDocument.BackColor = Color.White;
                    txtDocument.ForeColor = Color.Black;
                    toolStripMenuItemWrap.Checked = false;
                    txtDocument.ZoomFactor = 1;
                    zoomBar.Value = Convert.ToInt32(txtDocument.ZoomFactor);

                    DocumentTab dTab_ = (DocumentTab)hashTableTabCollection[Convert.ToInt32(selectedLabel.Tag)];
                    dTab_.textContent = txtDocument.Text;
                    dTab_.title = txtTopic.Text;
                    dTab_.content = txtDocument.Rtf;
                    dTab_.backgroundColor = txtDocument.BackColor;
                    dTab_.textColor = txtDocument.ForeColor;
                    dTab_.wordWrap = false;
                    dTab_.ZoomFactor = txtDocument.ZoomFactor;
                    dTab_.currentJobFile = null;

                    hashTableTabCollection[Convert.ToInt32(selectedLabel.Tag)] = dTab_;

                    return;
                }

                DeSelectAllLabels();

                int counter;
                int selectedTabIndex = -1;
                for (counter = 0; counter < flowLayoutPanel.Controls.Count; counter++)
                {
                    if (flowLayoutPanel.Controls[counter] == selectedLabel)
                    {
                        hashTableTabCollection.Remove(Convert.ToInt32(selectedLabel.Tag));

                        if (counter < flowLayoutPanel.Controls.Count - 1)
                        {
                            selectedTabIndex = Convert.ToInt32(flowLayoutPanel.Controls[counter + 1].Tag);

                            ((Label)flowLayoutPanel.Controls[counter + 1]).Image = Image.FromFile(Application.StartupPath + @"\Images\focused.png");

                            //flowLayoutPanel.Controls[counter + 1].BackColor = Color.White;
                            //flowLayoutPanel.Controls[counter + 1].ForeColor = Color.DimGray;
                        }
                        else if (counter == flowLayoutPanel.Controls.Count - 1)
                        {
                            selectedTabIndex = Convert.ToInt32(flowLayoutPanel.Controls[counter - 1].Tag);

                            ((Label)flowLayoutPanel.Controls[counter - 1]).Image = Image.FromFile(Application.StartupPath + @"\Images\focused.png");
                            //flowLayoutPanel.Controls[counter - 1].BackColor = Color.White;
                            //flowLayoutPanel.Controls[counter - 1].ForeColor = Color.DimGray;
                        }
                        break;
                    }
                }

                if (selectedTabIndex != -1)
                {
                    DocumentTab dTab = (DocumentTab)hashTableTabCollection[selectedTabIndex];
                    txtDocument.Rtf = dTab.content;
                    txtTopic.Text = dTab.title;
                    txtDocument.BackColor = dTab.backgroundColor;
                    txtDocument.Font = dTab.font;
                    txtDocument.ForeColor = dTab.textColor;
                    toolStripMenuItemWrap.Checked = dTab.wordWrap;
                    txtDocument.ZoomFactor = dTab.ZoomFactor;
                    zoomBar.Value = Convert.ToInt32(dTab.ZoomFactor);

                    flowLayoutPanel.Controls.Remove(selectedLabel);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                deleteLeftOverTabs();
            }
        }

        public void deleteLeftOverTabs()
        {
            try
            {
                foreach (int key in hashTableTabCollection.Keys)
                {
                    bool isFound = false;

                    foreach (Control item in flowLayoutPanel.Controls)
                    {
                        if (key == Convert.ToInt32(item.Tag))
                        {
                            isFound = true;
                            break;
                        }
                    }

                    if (!isFound)
                    {
                        hashTableTabCollection.Remove(key);
                        break;
                    }
                }
            }
            catch (Exception Exp)
            {
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            txtTopic.Focus();
        }

        private void contextMenuTabPage_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                ContextMenuStrip ctxSender = sender as ContextMenuStrip;
                Label lblSender = ctxSender.SourceControl as Label;

                label_Click(lblSender, null);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                for (int counter = flowLayoutPanel.Controls.Count - 1; counter >= 0; counter--)
                {
                    flowLayoutPanel.Controls.Remove(flowLayoutPanel.Controls[counter]);
                }

                hashTableTabCollection.Clear();

                toolStripMenuItemNewTab_Click(null, null);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void notificationIcon_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.TopMost = true;
                this.WindowState = FormWindowState.Maximized;
                this.Show();
                this.TopMost = false;
                this.WindowState = FormWindowState.Normal;
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        private void flowLayoutPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            try
            {
                if (flowLayoutPanel.VerticalScroll.Visible)
                {
                    if (!isStreched)
                    {
                        txtDocument.Location = new Point(txtDocument.Location.X + 22, txtDocument.Location.Y);
                        txtDocument.Size = new Size(txtDocument.Width - 22, txtDocument.Height);
                        isStreched = true;
                    }
                }
                else
                {
                    if (isStreched)
                    {
                        txtDocument.Location = new Point(txtDocument.Location.X - 22, txtDocument.Location.Y);
                        txtDocument.Size = new Size(txtDocument.Width + 22, txtDocument.Height);
                        isStreched = false;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void hideToTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                isMinimizeToTray = true;
                this.Hide();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmTextPad_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                autoSaveTimer_Elapsed(null, null);
                Application.Exit();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void setTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripDropDownButton1.ShowDropDown();
                txtTopic.Focus();
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion
    }
}
