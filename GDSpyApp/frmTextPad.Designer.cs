namespace NoteLocker
{
    partial class frmTextPad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTextPad));
            this.txtDocument = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemNewTab = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuIRemoveAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.hideToTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.findAndReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.goToLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorSettingsToolStripMenuItemTextColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.backgroundColorToolStripMenuItemBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.fontsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.removeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.txtTopic = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDocumentTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusSpringLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelWordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.documentFont = new System.Windows.Forms.FontDialog();
            this.zoomBar = new System.Windows.Forms.TrackBar();
            this.lblLogo = new System.Windows.Forms.Label();
            this.notificationIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuNotifications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuTabPage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).BeginInit();
            this.contextMenuNotifications.SuspendLayout();
            this.contextMenuTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDocument
            // 
            this.txtDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocument.EnableAutoDragDrop = true;
            this.txtDocument.Location = new System.Drawing.Point(145, 48);
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(487, 276);
            this.txtDocument.TabIndex = 0;
            this.txtDocument.Text = "";
            this.txtDocument.SelectionChanged += new System.EventHandler(this.txtDocument_SelectionChanged);
            this.txtDocument.TextChanged += new System.EventHandler(this.txtDocument_TextChanged);
            this.txtDocument.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocument_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.colorDialogToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItemSaveAs,
            this.toolStripSeparator2,
            this.toolStripMenuItemNewTab,
            this.toolStripMenuIRemoveAccount,
            this.toolStripSeparator7,
            this.hideToTrayToolStripMenuItem,
            this.toolStripSeparator11,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(233, 22);
            this.toolStripMenuItem3.Text = "&Save in Google© Drive";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItemSaveFile_Click);
            // 
            // toolStripMenuItemSaveAs
            // 
            this.toolStripMenuItemSaveAs.Name = "toolStripMenuItemSaveAs";
            this.toolStripMenuItemSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItemSaveAs.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItemSaveAs.Text = "Save &As";
            this.toolStripMenuItemSaveAs.Click += new System.EventHandler(this.toolStripMenuItemSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // toolStripMenuItemNewTab
            // 
            this.toolStripMenuItemNewTab.Name = "toolStripMenuItemNewTab";
            this.toolStripMenuItemNewTab.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.toolStripMenuItemNewTab.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItemNewTab.Text = "New &Tab";
            this.toolStripMenuItemNewTab.Click += new System.EventHandler(this.toolStripMenuItemNewTab_Click);
            // 
            // toolStripMenuIRemoveAccount
            // 
            this.toolStripMenuIRemoveAccount.Name = "toolStripMenuIRemoveAccount";
            this.toolStripMenuIRemoveAccount.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuIRemoveAccount.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuIRemoveAccount.Text = "New &Window";
            this.toolStripMenuIRemoveAccount.Click += new System.EventHandler(this.toolStripMenuINewWindow_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(185, 6);
            // 
            // hideToTrayToolStripMenuItem
            // 
            this.hideToTrayToolStripMenuItem.Name = "hideToTrayToolStripMenuItem";
            this.hideToTrayToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.hideToTrayToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.hideToTrayToolStripMenuItem.Text = "&Hide to tray";
            this.hideToTrayToolStripMenuItem.Click += new System.EventHandler(this.hideToTrayToolStripMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(185, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.toolStripSeparator8,
            this.undoToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator9,
            this.findAndReplaceToolStripMenuItem,
            this.toolStripSeparator10,
            this.goToLineToolStripMenuItem,
            this.toolStripSeparator12,
            this.setTitleToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(167, 6);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cutToolStripMenuItem.Text = "&Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.copyToolStripMenuItem.Text = "C&opy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(167, 6);
            // 
            // findAndReplaceToolStripMenuItem
            // 
            this.findAndReplaceToolStripMenuItem.Name = "findAndReplaceToolStripMenuItem";
            this.findAndReplaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findAndReplaceToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.findAndReplaceToolStripMenuItem.Text = "&Find";
            this.findAndReplaceToolStripMenuItem.Click += new System.EventHandler(this.findAndReplaceToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(167, 6);
            // 
            // goToLineToolStripMenuItem
            // 
            this.goToLineToolStripMenuItem.Name = "goToLineToolStripMenuItem";
            this.goToLineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.goToLineToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.goToLineToolStripMenuItem.Text = "&Go to Line";
            this.goToLineToolStripMenuItem.Click += new System.EventHandler(this.goToLineToolStripMenuItem_Click);
            // 
            // colorDialogToolStripMenuItem
            // 
            this.colorDialogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textColorSettingsToolStripMenuItemTextColor,
            this.toolStripSeparator3,
            this.backgroundColorToolStripMenuItemBackColor,
            this.toolStripSeparator4,
            this.fontsToolStripMenuItem,
            this.toolStripSeparator6,
            this.toolStripMenuItemWrap});
            this.colorDialogToolStripMenuItem.Name = "colorDialogToolStripMenuItem";
            this.colorDialogToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.colorDialogToolStripMenuItem.Text = "&View";
            // 
            // textColorSettingsToolStripMenuItemTextColor
            // 
            this.textColorSettingsToolStripMenuItemTextColor.Name = "textColorSettingsToolStripMenuItemTextColor";
            this.textColorSettingsToolStripMenuItemTextColor.Size = new System.Drawing.Size(170, 22);
            this.textColorSettingsToolStripMenuItemTextColor.Text = "&Text Color";
            this.textColorSettingsToolStripMenuItemTextColor.Click += new System.EventHandler(this.textColorSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(167, 6);
            // 
            // backgroundColorToolStripMenuItemBackColor
            // 
            this.backgroundColorToolStripMenuItemBackColor.Name = "backgroundColorToolStripMenuItemBackColor";
            this.backgroundColorToolStripMenuItemBackColor.Size = new System.Drawing.Size(170, 22);
            this.backgroundColorToolStripMenuItemBackColor.Text = "&Background Color";
            this.backgroundColorToolStripMenuItemBackColor.Click += new System.EventHandler(this.backgroundColorToolStripMenuItemBackColor_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(167, 6);
            // 
            // fontsToolStripMenuItem
            // 
            this.fontsToolStripMenuItem.Name = "fontsToolStripMenuItem";
            this.fontsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.fontsToolStripMenuItem.Text = "&Fonts";
            this.fontsToolStripMenuItem.Click += new System.EventHandler(this.fontsToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(167, 6);
            // 
            // toolStripMenuItemWrap
            // 
            this.toolStripMenuItemWrap.Checked = true;
            this.toolStripMenuItemWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemWrap.Name = "toolStripMenuItemWrap";
            this.toolStripMenuItemWrap.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItemWrap.Text = "Word Wrap";
            this.toolStripMenuItemWrap.Click += new System.EventHandler(this.toolStripMenuItemWrap_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationsToolStripMenuItem,
            this.toolStripSeparator5,
            this.removeAccountToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // configurationsToolStripMenuItem
            // 
            this.configurationsToolStripMenuItem.Name = "configurationsToolStripMenuItem";
            this.configurationsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.configurationsToolStripMenuItem.Text = "Global &Configurations";
            this.configurationsToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(162, 6);
            // 
            // removeAccountToolStripMenuItem
            // 
            this.removeAccountToolStripMenuItem.Name = "removeAccountToolStripMenuItem";
            this.removeAccountToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.removeAccountToolStripMenuItem.Text = "&Remove Account";
            this.removeAccountToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuIRemoveAccount_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelDocumentTitle,
            this.toolStripStatusSpringLabel,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelWordCount,
            this.toolStripStatusZoom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 330);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(633, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtTopic});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(63, 20);
            this.toolStripDropDownButton1.Text = "Set Title";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // txtTopic
            // 
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(300, 23);
            this.txtTopic.TextChanged += new System.EventHandler(this.txtTopic_TextChanged);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel1.Text = "     Title Name :";
            // 
            // toolStripStatusLabelDocumentTitle
            // 
            this.toolStripStatusLabelDocumentTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelDocumentTitle.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabelDocumentTitle.Name = "toolStripStatusLabelDocumentTitle";
            this.toolStripStatusLabelDocumentTitle.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripStatusLabelDocumentTitle.Size = new System.Drawing.Size(139, 17);
            this.toolStripStatusLabelDocumentTitle.Text = "[ Document Title Here ]";
            // 
            // toolStripStatusSpringLabel
            // 
            this.toolStripStatusSpringLabel.Name = "toolStripStatusSpringLabel";
            this.toolStripStatusSpringLabel.Size = new System.Drawing.Size(106, 17);
            this.toolStripStatusSpringLabel.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(78, 17);
            this.toolStripStatusLabel2.Text = "Word Count :";
            // 
            // toolStripStatusLabelWordCount
            // 
            this.toolStripStatusLabelWordCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelWordCount.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabelWordCount.Name = "toolStripStatusLabelWordCount";
            this.toolStripStatusLabelWordCount.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripStatusLabelWordCount.RightToLeftAutoMirrorImage = true;
            this.toolStripStatusLabelWordCount.Size = new System.Drawing.Size(106, 17);
            this.toolStripStatusLabelWordCount.Spring = true;
            this.toolStripStatusLabelWordCount.Text = "0";
            this.toolStripStatusLabelWordCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusZoom
            // 
            this.toolStripStatusZoom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusZoom.Name = "toolStripStatusZoom";
            this.toolStripStatusZoom.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusZoom.Text = "Zoom";
            this.toolStripStatusZoom.Click += new System.EventHandler(this.toolStripStatusZoom_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.AddExtension = false;
            // 
            // colorPicker
            // 
            this.colorPicker.FullOpen = true;
            // 
            // documentFont
            // 
            this.documentFont.Color = System.Drawing.SystemColors.ControlText;
            this.documentFont.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // zoomBar
            // 
            this.zoomBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomBar.AutoSize = false;
            this.zoomBar.BackColor = System.Drawing.Color.Black;
            this.zoomBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zoomBar.Location = new System.Drawing.Point(514, 330);
            this.zoomBar.Name = "zoomBar";
            this.zoomBar.Size = new System.Drawing.Size(118, 21);
            this.zoomBar.TabIndex = 3;
            this.zoomBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.zoomBar.Visible = false;
            this.zoomBar.Scroll += new System.EventHandler(this.zoomBar_Scroll);
            this.zoomBar.Leave += new System.EventHandler(this.zoomBar_Leave);
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogo.Image = ((System.Drawing.Image)(resources.GetObject("lblLogo.Image")));
            this.lblLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLogo.Location = new System.Drawing.Point(425, 2);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(205, 43);
            this.lblLogo.TabIndex = 4;
            this.lblLogo.Text = "Powered with ";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // notificationIcon
            // 
            this.notificationIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notificationIcon.BalloonTipText = "Note Locker is running in the background";
            this.notificationIcon.BalloonTipTitle = "Note Locker is still running";
            this.notificationIcon.ContextMenuStrip = this.contextMenuNotifications;
            this.notificationIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notificationIcon.Icon")));
            this.notificationIcon.Text = "Google Docs";
            this.notificationIcon.Visible = true;
            this.notificationIcon.DoubleClick += new System.EventHandler(this.notificationIcon_DoubleClick);
            // 
            // contextMenuNotifications
            // 
            this.contextMenuNotifications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.settingsToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.contextMenuNotifications.Name = "contextMenuNotifications";
            this.contextMenuNotifications.Size = new System.Drawing.Size(151, 70);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.showToolStripMenuItem.Text = "Show &Window";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.exitToolStripMenuItem1.Text = "&Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 48);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel.Size = new System.Drawing.Size(163, 276);
            this.flowLayoutPanel.TabIndex = 7;
            this.flowLayoutPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanel_ControlAdded);
            this.flowLayoutPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanel_ControlAdded);
            // 
            // contextMenuTabPage
            // 
            this.contextMenuTabPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.closeAllToolStripMenuItem});
            this.contextMenuTabPage.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contextMenuTabPage.Name = "contextMenuTabPage";
            this.contextMenuTabPage.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuTabPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuTabPage.Size = new System.Drawing.Size(121, 48);
            this.contextMenuTabPage.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuTabPage_Opening);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.closeAllToolStripMenuItem.Text = "Close &All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // setTitleToolStripMenuItem
            // 
            this.setTitleToolStripMenuItem.Name = "setTitleToolStripMenuItem";
            this.setTitleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.setTitleToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.setTitleToolStripMenuItem.Text = "S&et Title";
            this.setTitleToolStripMenuItem.Click += new System.EventHandler(this.setTitleToolStripMenuItem_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(167, 6);
            // 
            // frmTextPad
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 352);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.zoomBar);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTextPad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note Locker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTextPad_FormClosing);
            this.Load += new System.EventHandler(this.frmTextPad_Load);
            this.Resize += new System.EventHandler(this.frmTextPad_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).EndInit();
            this.contextMenuNotifications.ResumeLayout(false);
            this.contextMenuTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveAs;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNewTab;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripTextBox txtTopic;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDocumentTitle;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusSpringLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelWordCount;
        private System.Windows.Forms.ToolStripMenuItem colorDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textColorSettingsToolStripMenuItemTextColor;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItemBackColor;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.ToolStripMenuItem fontsToolStripMenuItem;
        private System.Windows.Forms.FontDialog documentFont;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIRemoveAccount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWrap;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TrackBar zoomBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusZoom;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem findAndReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem goToLineToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notificationIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuNotifications;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuTabPage;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        public System.Windows.Forms.RichTextBox txtDocument;
        private System.Windows.Forms.ToolStripMenuItem hideToTrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem setTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
    }
}

