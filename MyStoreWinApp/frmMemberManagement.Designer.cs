
namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            this.bntLoad = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.gbCityCountry = new System.Windows.Forms.GroupBox();
            this.lbSearchCountry = new System.Windows.Forms.Label();
            this.lbSearchCity = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.gbIDName = new System.Windows.Forms.GroupBox();
            this.lbSearchName = new System.Windows.Forms.Label();
            this.lbSearchID = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.dvgMemberList = new System.Windows.Forms.DataGridView();
            this.gbInformation.SuspendLayout();
            this.gbCityCountry.SuspendLayout();
            this.panel6.SuspendLayout();
            this.gbIDName.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // bntLoad
            // 
            this.bntLoad.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntLoad.Location = new System.Drawing.Point(133, 374);
            this.bntLoad.Name = "bntLoad";
            this.bntLoad.Size = new System.Drawing.Size(94, 29);
            this.bntLoad.TabIndex = 6;
            this.bntLoad.Text = "Load";
            this.bntLoad.UseVisualStyleBackColor = true;
            this.bntLoad.Click += new System.EventHandler(this.bntLoad_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(277, 374);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 29);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(438, 374);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(279, 731);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbInformation
            // 
            this.gbInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInformation.Controls.Add(this.gbCityCountry);
            this.gbInformation.Controls.Add(this.panel6);
            this.gbInformation.Controls.Add(this.gbIDName);
            this.gbInformation.Controls.Add(this.panel5);
            this.gbInformation.Controls.Add(this.panel4);
            this.gbInformation.Controls.Add(this.panel3);
            this.gbInformation.Controls.Add(this.panel2);
            this.gbInformation.Controls.Add(this.panel1);
            this.gbInformation.Controls.Add(this.bntLoad);
            this.gbInformation.Controls.Add(this.btnCreate);
            this.gbInformation.Controls.Add(this.btnDelete);
            this.gbInformation.Location = new System.Drawing.Point(2, 3);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(689, 436);
            this.gbInformation.TabIndex = 10;
            this.gbInformation.TabStop = false;
            // 
            // gbCityCountry
            // 
            this.gbCityCountry.Controls.Add(this.lbSearchCountry);
            this.gbCityCountry.Controls.Add(this.lbSearchCity);
            this.gbCityCountry.Controls.Add(this.cbCountry);
            this.gbCityCountry.Controls.Add(this.cbCity);
            this.gbCityCountry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbCityCountry.Location = new System.Drawing.Point(354, 193);
            this.gbCityCountry.Name = "gbCityCountry";
            this.gbCityCountry.Size = new System.Drawing.Size(313, 130);
            this.gbCityCountry.TabIndex = 17;
            this.gbCityCountry.TabStop = false;
            this.gbCityCountry.Text = "Search City/Country";
            // 
            // lbSearchCountry
            // 
            this.lbSearchCountry.AutoSize = true;
            this.lbSearchCountry.Location = new System.Drawing.Point(6, 84);
            this.lbSearchCountry.Name = "lbSearchCountry";
            this.lbSearchCountry.Size = new System.Drawing.Size(71, 23);
            this.lbSearchCountry.TabIndex = 19;
            this.lbSearchCountry.Text = "Country";
            // 
            // lbSearchCity
            // 
            this.lbSearchCity.AutoSize = true;
            this.lbSearchCity.Location = new System.Drawing.Point(6, 32);
            this.lbSearchCity.Name = "lbSearchCity";
            this.lbSearchCity.Size = new System.Drawing.Size(39, 23);
            this.lbSearchCity.TabIndex = 18;
            this.lbSearchCity.Text = "City";
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(106, 81);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(205, 31);
            this.cbCountry.TabIndex = 17;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(106, 24);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(205, 31);
            this.cbCity.TabIndex = 16;
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtPassword);
            this.panel6.Controls.Add(this.lbPassword);
            this.panel6.Location = new System.Drawing.Point(351, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(316, 45);
            this.panel6.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(109, -1);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(207, 27);
            this.txtPassword.TabIndex = 1;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(1, 3);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(94, 22);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Password";
            // 
            // gbIDName
            // 
            this.gbIDName.Controls.Add(this.lbSearchName);
            this.gbIDName.Controls.Add(this.lbSearchID);
            this.gbIDName.Controls.Add(this.txtSearchName);
            this.gbIDName.Controls.Add(this.btnSearch);
            this.gbIDName.Controls.Add(this.txtSearchID);
            this.gbIDName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbIDName.Location = new System.Drawing.Point(19, 192);
            this.gbIDName.Name = "gbIDName";
            this.gbIDName.Size = new System.Drawing.Size(275, 154);
            this.gbIDName.TabIndex = 13;
            this.gbIDName.TabStop = false;
            this.gbIDName.Text = "Search ID/ Name";
            // 
            // lbSearchName
            // 
            this.lbSearchName.AutoSize = true;
            this.lbSearchName.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSearchName.Location = new System.Drawing.Point(6, 82);
            this.lbSearchName.Name = "lbSearchName";
            this.lbSearchName.Size = new System.Drawing.Size(60, 22);
            this.lbSearchName.TabIndex = 19;
            this.lbSearchName.Text = "Name";
            // 
            // lbSearchID
            // 
            this.lbSearchID.AutoSize = true;
            this.lbSearchID.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSearchID.Location = new System.Drawing.Point(6, 37);
            this.lbSearchID.Name = "lbSearchID";
            this.lbSearchID.Size = new System.Drawing.Size(30, 22);
            this.lbSearchID.TabIndex = 18;
            this.lbSearchID.Text = "ID";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(68, 78);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(201, 30);
            this.txtSearchName.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSearch.Location = new System.Drawing.Point(82, 119);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(68, 33);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(201, 30);
            this.txtSearchID.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtCountry);
            this.panel5.Controls.Add(this.lbCountry);
            this.panel5.Location = new System.Drawing.Point(353, 124);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(312, 45);
            this.panel5.TabIndex = 12;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(107, 1);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(207, 27);
            this.txtCountry.TabIndex = 1;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCountry.Location = new System.Drawing.Point(1, 3);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(75, 22);
            this.lbCountry.TabIndex = 0;
            this.lbCountry.Text = "Country";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtCity);
            this.panel4.Controls.Add(this.lbCity);
            this.panel4.Location = new System.Drawing.Point(352, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(313, 45);
            this.panel4.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(108, 2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(207, 27);
            this.txtCity.TabIndex = 1;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCity.Location = new System.Drawing.Point(1, 3);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(42, 22);
            this.lbCity.TabIndex = 0;
            this.lbCity.Text = "City";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.lbEmail);
            this.panel3.Location = new System.Drawing.Point(11, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 45);
            this.panel3.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(77, -1);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 27);
            this.txtEmail.TabIndex = 1;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(1, 3);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(57, 22);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Location = new System.Drawing.Point(10, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 45);
            this.panel2.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, -1);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 27);
            this.txtName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(1, 3);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(60, 22);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Location = new System.Drawing.Point(10, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 45);
            this.panel1.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(77, -1);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(207, 27);
            this.txtID.TabIndex = 1;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbID.Location = new System.Drawing.Point(1, 3);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(30, 22);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID";
            // 
            // dvgMemberList
            // 
            this.dvgMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMemberList.Location = new System.Drawing.Point(0, 445);
            this.dvgMemberList.Name = "dvgMemberList";
            this.dvgMemberList.RowHeadersWidth = 51;
            this.dvgMemberList.RowTemplate.Height = 29;
            this.dvgMemberList.Size = new System.Drawing.Size(691, 280);
            this.dvgMemberList.TabIndex = 7;
            this.dvgMemberList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgMemberList_CellDoubleClick);
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(703, 772);
            this.Controls.Add(this.gbInformation);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dvgMemberList);
            this.Name = "frmMemberManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMemberManagement";
            this.Load += new System.EventHandler(this.frmMemberManagement_Load);
            this.gbInformation.ResumeLayout(false);
            this.gbCityCountry.ResumeLayout(false);
            this.gbCityCountry.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.gbIDName.ResumeLayout(false);
            this.gbIDName.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMemberList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bntLoad;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.GroupBox gbIDName;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbCityCountry;
        private System.Windows.Forms.Label lbSearchCountry;
        private System.Windows.Forms.Label lbSearchCity;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.DataGridView dvgMemberList;
        private System.Windows.Forms.Label lbSearchName;
        private System.Windows.Forms.Label lbSearchID;
        private System.Windows.Forms.TextBox txtSearchName;
    }
}