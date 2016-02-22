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
    public partial class frmFindInDoc : Form
    {
        frmTextPad txtPad = null;
        static frmFindInDoc fDoc = null;

        private frmFindInDoc(frmTextPad txtPad)
        {
            this.txtPad = txtPad;
            InitializeComponent();
        }

        public void FindInDocument(string value)
        {
            try
            {
                int result = txtPad.txtDocument.Find(value, txtPad.txtDocument.SelectionStart + txtPad.txtDocument.SelectionLength, RichTextBoxFinds.None);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                FindInDocument(txtFindText.Text);
                txtPad.BringToFront();
                txtPad.Show();
                txtPad.txtDocument.Focus();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public static frmFindInDoc GetInstance(frmTextPad txtPad)
        {
            try
            {
                if (frmFindInDoc.fDoc == null)
                    frmFindInDoc.fDoc = new frmFindInDoc(txtPad);
                else
                    return frmFindInDoc.fDoc;

                return frmFindInDoc.fDoc;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void frmFindInDoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                frmFindInDoc.fDoc = null;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
