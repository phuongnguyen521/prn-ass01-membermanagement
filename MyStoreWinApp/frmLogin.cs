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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        // Intialize membeRepository for function
        public IMemberRepository memberRepository = new MemberRepository();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            MemberObject member = memberRepository.Login(email, password);
            // member exists
            if(member != null)
            {
                MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string memberName = member.MemberName;
                // user is Admin
                if (memberName.Equals("Admin"))
                {
                    frmMemberManagement memberManagement = new frmMemberManagement
                    {
                        loginMember = member
                    };
                    this.Hide();
                    memberManagement.ShowDialog();
                    txtPassword.Text = null;
                    this.Show();
                    


                } 
                // user is not Admin
                else
                {
                    frmMemberDetail memberDetail = new frmMemberDetail
                    {
                        MemberRepo = memberRepository,
                        CreateOrUpdate = false,
                        memberObj = member
                    };
                    this.Hide();
                    memberDetail.ShowDialog();
                    txtPassword.Text = null;
                    this.Show();
                }
            }
            //member does not exist
            else
            {
                if (MessageBox.Show("Login Failed","Login",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        => Close();
    }
}
