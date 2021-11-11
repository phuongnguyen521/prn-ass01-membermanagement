using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberDetail : Form
    {
        public frmMemberDetail()
        {
            InitializeComponent();
        }

        // Initialize
        public IMemberRepository MemberRepo { get; set; }
        public bool CreateOrUpdate { get; set; } //Insert: True; Update: False
        public MemberObject memberObj { get; set; }

       
        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            txtID.Enabled = CreateOrUpdate;
            // Update
            if (CreateOrUpdate == false)
            {
                txtID.Text = memberObj.MemberID.ToString();
                txtName.Text = memberObj.MemberName.Trim().ToString();
                txtEmail.Text = memberObj.Email.Trim().ToString();
                txtPassword.Text = memberObj.Password.Trim().ToString();
                txtCity.Text = memberObj.City.Trim().ToString();
                txtCountry.Text = memberObj.Country.Trim().ToString();
            }
        }// end frmMemberDetail_Load

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new MemberObject
                {
                    MemberID = int.Parse(txtID.Text),
                    MemberName = txtName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };
                //Add a new member
                if (CreateOrUpdate)
                {
                    MemberRepo.AddMember(member);
                    MessageBox.Show("Add a new member Successfully!", "Add a new member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } //Update a member 
                else
                {
                    MemberRepo.UpdateMember(member);
                    MessageBox.Show("Update a member Successfully!", "Update a member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, CreateOrUpdate == true ? "Add a new member" : "Update a member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
