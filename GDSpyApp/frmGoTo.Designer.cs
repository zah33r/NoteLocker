namespace NoteLocker
{
    partial class frmGoTo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTimeInterval = new System.Windows.Forms.Label();
            this.txtLineNumer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoTo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTimeInterval);
            this.panel1.Controls.Add(this.txtLineNumer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 44);
            this.panel1.TabIndex = 8;
            // 
            // lblTimeInterval
            // 
            this.lblTimeInterval.AutoSize = true;
            this.lblTimeInterval.Location = new System.Drawing.Point(15, 13);
            this.lblTimeInterval.Name = "lblTimeInterval";
            this.lblTimeInterval.Size = new System.Drawing.Size(52, 13);
            this.lblTimeInterval.TabIndex = 0;
            this.lblTimeInterval.Text = "Go to line";
            // 
            // txtLineNumer
            // 
            this.txtLineNumer.Location = new System.Drawing.Point(79, 10);
            this.txtLineNumer.Name = "txtLineNumer";
            this.txtLineNumer.Size = new System.Drawing.Size(43, 20);
            this.txtLineNumer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "( Line Number )";
            // 
            // btnGoTo
            // 
            this.btnGoTo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGoTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGoTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoTo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoTo.ForeColor = System.Drawing.Color.Black;
            this.btnGoTo.Location = new System.Drawing.Point(165, 66);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(74, 23);
            this.btnGoTo.TabIndex = 7;
            this.btnGoTo.Text = "Go";
            this.btnGoTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGoTo.Click += new System.EventHandler(this.btnGoTo_Click);
            // 
            // frmGoTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 101);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGoTo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGoTo";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGoTo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTimeInterval;
        private System.Windows.Forms.TextBox txtLineNumer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnGoTo;

    }
}