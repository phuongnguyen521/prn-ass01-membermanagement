using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        IMemberRepository memberRepo = new MemberRepository();
        // Create a data source
        BindingSource source;
        BindingSource citySource;
        BindingSource countrySource;
        public MemberObject loginMember;
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            txtID.Enabled = false;
            txtName.Enabled = false;
            txtEmail.Enabled = false;
            txtPassword.Enabled = false;
            txtPassword.PasswordChar = '*';
            txtCity.Enabled = false;
            txtCountry.Enabled = false;
            dvgMemberList.CellDoubleClick += dvgMemberList_CellDoubleClick;
            
        }

        // Update member
        private void dvgMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetail memberDetail = new frmMemberDetail
            {
                CreateOrUpdate = false, //Insert: true, Update: false
                memberObj = GetMemberObject(),
                MemberRepo = memberRepo
            };

            if (memberDetail.ShowDialog() == DialogResult.Cancel)
            {
                LoadMemberList();
            }
        }

        private void ClearText()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
        }

        private MemberObject GetMemberObject()
        {
            MemberObject memberobj = null;
            try
            {
                memberobj = new MemberObject
                {
                    MemberID = int.Parse(txtID.Text),
                    MemberName = txtName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return memberobj;
        }


        private void LoadMemberList(bool search = false, IEnumerable<MemberObject> searchDataSource = null)
        {
            var members = memberRepo.GetMembers().OrderByDescending(temp => temp.MemberName);
            try
            {
                source = new BindingSource();
                if (search)
                {
                    source.DataSource = searchDataSource;
                }
                else
                {
                    source.DataSource = members;

                    var countryList = from member in members
                                      where !string.IsNullOrEmpty(member.Country.Trim())
                                      orderby member.Country ascending
                                      select member.Country;
                    countryList = countryList.Prepend("All");
                    countryList = countryList.Distinct();

                    var cityList = from member in members
                                   where !string.IsNullOrEmpty(member.City.Trim())
                                   orderby member.City ascending
                                   select member.City;
                    cityList = cityList.Prepend("All");
                    cityList = cityList.Distinct();

                    if (members.Count() > 0)
                    {
                        countrySource = new BindingSource();
                        countrySource.DataSource = countryList;
                        cbCountry.DataSource = null;
                        cbCountry.DataSource = countrySource;

                        citySource = new BindingSource();
                        citySource.DataSource = cityList;
                        cbCity.DataSource = null;
                        cbCity.DataSource = citySource;
                        txtSearchID.Text = String.Empty;
                        txtSearchName.Text = String.Empty;
                    }
                }

                txtID.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtID.DataBindings.Add("Text", source, "MemberID");
                txtName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dvgMemberList.DataSource = null;
                dvgMemberList.DataSource = source;

                if (members.Count() > 0)
                {
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnDelete.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member List");
            }
        }


        private void bntLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmMemberDetail memberDetail = new frmMemberDetail
            {
                Text = "Add a new member",
                CreateOrUpdate = true, //Insert: true, Update: false
                MemberRepo = memberRepo
            };
            if (memberDetail.ShowDialog() == DialogResult.Cancel)
            {
                LoadMemberList();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var member = GetMemberObject();
            if (member.MemberID.Equals(loginMember.MemberID))
            {
                MessageBox.Show($"You cannot delete this {member.MemberName}", "Delete a member", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                DialogResult result;
                result = MessageBox.Show($"Do you want to delete this {txtName.Text}?", "Delete a member", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        memberRepo.DeleteMember(member.MemberID);
                        LoadMemberList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Delete a memeber");
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        => Close();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = txtSearchID.Text.ToString();
                string Name = txtSearchName.Text.ToString();
                IEnumerable<MemberObject> searchResult = memberRepo.SearchIDAndName(ID, Name);
                // ID exists
                if (searchResult.Any())
                {
                    LoadMemberList(true, searchResult);
                } // ID does not exist
                else
                {
                    MessageBox.Show("No result matches with search ID or name", "Search ID and Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search ID or Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbCity.DataSource != null)
                {
                    string city = cbCity.SelectedItem.ToString();
                    if (!string.IsNullOrEmpty(city))
                    {
                        if (city.Equals("All"))
                        {
                            LoadMemberList();
                        }
                        else
                        {
                            IEnumerable<MemberObject> searchResult = memberRepo.SearchCity(city);
                            // city exists
                            if (searchResult.Any())
                            {
                                LoadMemberList(true, searchResult);
                            }// city does not exist
                            else
                            {
                                MessageBox.Show("No result matches with search City", "Search City", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Search City", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbCountry.DataSource != null)
                {
                    string country = cbCountry.SelectedItem.ToString();
                    if (!string.IsNullOrEmpty(country))
                    {
                        if (country.Equals("All"))
                        {
                            LoadMemberList();
                        }
                        else
                        {
                            IEnumerable<MemberObject> searchResult = memberRepo.SearchCity(country);
                            // country exists
                            if (searchResult.Any())
                            {
                                LoadMemberList(true, searchResult);
                            }// country does not exist
                            else
                            {
                                MessageBox.Show("No result matches with search Country", "Search Country", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Country", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
