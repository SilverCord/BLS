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
    public partial class fmrViewCustomerForm : Form
    {
        public fmrViewCustomerForm(BLSSchema.ctCustomerRow row)
        {
            InitializeComponent();
            lblName.Text = row.CustName;
            lblFatherName.Text = row.Father_Name;
            lblMembID.Text = row.CustomerID.ToString();
            lblDOB.Text = row.DOB.Substring(0,10);
            lblDOR.Text = row.MembershipDate.Substring(0, 10);
            lblMobileNumber.Text = row.Student_Mobile;
            lblCollegeName.Text = row.CollegeName;
            lblCourse.Text = row.Course;
            lblDuration.Text = row.CourseDuration;
            lblMembType.Text = row.Address;
            pbCustImage.ImageLocation = row.ImagePath;
            lblMembType.Text = Program.MainObj.GetDetailedCustomerType(row.MembershipType);
            lblCustAddress.Text = row.Address;
       }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
