using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryDesign_frontEndUI.Forms
{
    public partial class frmReturnDetails : Form
    {
        internal int _intCurrentCount = 0;
        frmReturn __frmParentReference = null;
        
        public frmReturnDetails(frmReturn ParentReference)
        {
            InitializeComponent();
            __frmParentReference = ParentReference;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtCount.Text) > _intCurrentCount)
            {
                MessageBox.Show("Please enter the valid count", "Error");
                return;
            }
            else
            {
                __frmParentReference._intCurrentSelectedCount = int.Parse(txtCount.Text);
                Close();
            }
        }
    }
}
