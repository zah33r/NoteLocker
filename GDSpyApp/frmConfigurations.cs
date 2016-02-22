using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace NoteLocker
{
    public partial class frmConfigurations : Form
    {
        frmTextPad parent = null;

        public frmConfigurations(frmTextPad frmTP)
        {
            InitializeComponent();
            this.parent = frmTP;
        }

        private void btnUpdateSettings_Click(object sender, EventArgs e)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (System.IO.Directory.Exists(txtAutoSaveLocation.Text.Trim()))
                DriveSettings.autoSaveLocation = txtAutoSaveLocation.Text.Trim();
            else
            {
                string Message = "The provided path was not found. Would you like to set below location for the auto-save location?" + Environment.NewLine + Environment.NewLine + "i.e: " + System.IO.Path.Combine(Application.StartupPath, "Documents");
                DialogResult result = MessageBox.Show(Message, this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                
                if (DialogResult.Yes == result)
                    DriveSettings.autoSaveLocation = System.IO.Path.Combine(Application.StartupPath, "Documents");
                else if (DialogResult.Cancel == result)
                    return;
            }

            configFile.AppSettings.Settings["isLocalSaveOn"].Value = checkBoxLocal.Checked.ToString();
            configFile.AppSettings.Settings["isRemoteSaveOn"].Value = checkBoxRemote.Checked.ToString();
            configFile.AppSettings.Settings["autoSaveInterval"].Value = txtMinutes.Text;
            configFile.AppSettings.Settings["autoSaveDirectory"].Value = DriveSettings.autoSaveLocation;
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            DriveSettings.isLocalSaveOn = checkBoxLocal.Checked;
            DriveSettings.isRemoteSaveOn = checkBoxRemote.Checked;
            DriveSettings.autoSaveInterval = Convert.ToInt32(txtMinutes.Text);

            this.parent.autoSaveTimer.Enabled = false;
            this.parent.autoSaveTimer.Interval = DriveSettings.autoSaveInterval * 60 * 1000;
            this.parent.autoSaveTimer.Enabled = true;

            MessageBox.Show("Settings updated successfully.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void frmConfigurations_Load(object sender, EventArgs e)
        {
            try
            {
                //this.parent.autoSaveTimer.Enabled = false;
                //this.parent.autoSaveTimer.Elapsed -= new System.Timers.ElapsedEventHandler(this.parent.autoSaveTimer_Elapsed);

                txtAutoSaveLocation.Text = DriveSettings.autoSaveLocation;
                checkBoxLocal.Checked = DriveSettings.isLocalSaveOn;
                checkBoxRemote.Checked = DriveSettings.isRemoteSaveOn;
                txtMinutes.Text = DriveSettings.autoSaveInterval.ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}
