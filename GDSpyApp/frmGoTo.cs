using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NoteLocker
{
    public partial class frmGoTo : Form
    {
        frmTextPad txtPad = null;

        public frmGoTo(frmTextPad txtPad)
        {
            this.txtPad = txtPad;
            InitializeComponent();
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            try
            {
                int number = -1;
                Int32.TryParse(txtLineNumer.Text.Trim(), out number);

                if (number != -1)
                    txtPad.SetCaretLine(number);
                else
                    MessageBox.Show("Please enter a valid line number to go to.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
