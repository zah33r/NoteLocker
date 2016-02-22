namespace NoteLocker
{
    partial class frmConfigurations
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
            this.lblTimeInterval = new System.Windows.Forms.Label();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.checkBoxLocal = new System.Windows.Forms.CheckBox();
            this.checkBoxRemote = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateSettings = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAutoSaveLocation = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimeInterval
            // 
            this.lblTimeInterval.AutoSize = true;
            this.lblTimeInterval.Location = new System.Drawing.Point(15, 16);
            this.lblTimeInterval.Name = "lblTimeInterval";
            this.lblTimeInterval.Size = new System.Drawing.Size(136, 13);
            this.lblTimeInterval.TabIndex = 0;
            this.lblTimeInterval.Text = "Time Interval for Auto Save";
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(185, 12);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(43, 20);
            this.txtMinutes.TabIndex = 1;
            // 
            // checkBoxLocal
            // 
            this.checkBoxLocal.AutoSize = true;
            this.checkBoxLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxLocal.Location = new System.Drawing.Point(19, 62);
            this.checkBoxLocal.Name = "checkBoxLocal";
            this.checkBoxLocal.Size = new System.Drawing.Size(154, 17);
            this.checkBoxLocal.TabIndex = 2;
            this.checkBoxLocal.Text = "Auto save to local directory";
            this.checkBoxLocal.UseVisualStyleBackColor = true;
            // 
            // checkBoxRemote
            // 
            this.checkBoxRemote.AutoSize = true;
            this.checkBoxRemote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxRemote.Location = new System.Drawing.Point(19, 89);
            this.checkBoxRemote.Name = "checkBoxRemote";
            this.checkBoxRemote.Size = new System.Drawing.Size(160, 17);
            this.checkBoxRemote.TabIndex = 3;
            this.checkBoxRemote.Text = "Auto save to Google© Drive";
            this.checkBoxRemote.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "( Minutes )";
            // 
            // btnUpdateSettings
            // 
            this.btnUpdateSettings.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnUpdateSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSettings.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateSettings.Location = new System.Drawing.Point(257, 140);
            this.btnUpdateSettings.Name = "btnUpdateSettings";
            this.btnUpdateSettings.Size = new System.Drawing.Size(74, 23);
            this.btnUpdateSettings.TabIndex = 5;
            this.btnUpdateSettings.Text = "Update";
            this.btnUpdateSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateSettings.Click += new System.EventHandler(this.btnUpdateSettings_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAutoSaveLocation);
            this.panel1.Controls.Add(this.lblTimeInterval);
            this.panel1.Controls.Add(this.txtMinutes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBoxLocal);
            this.panel1.Controls.Add(this.checkBoxRemote);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 123);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Auto save location";
            // 
            // txtAutoSaveLocation
            // 
            this.txtAutoSaveLocation.Location = new System.Drawing.Point(185, 35);
            this.txtAutoSaveLocation.Name = "txtAutoSaveLocation";
            this.txtAutoSaveLocation.Size = new System.Drawing.Size(115, 20);
            this.txtAutoSaveLocation.TabIndex = 6;
            // 
            // frmConfigurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 171);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdateSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConfigurations";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Global Configurations";
            this.Load += new System.EventHandler(this.frmConfigurations_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTimeInterval;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.CheckBox checkBoxLocal;
        private System.Windows.Forms.CheckBox checkBoxRemote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnUpdateSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAutoSaveLocation;
    }
}