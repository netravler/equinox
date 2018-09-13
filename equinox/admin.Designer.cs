namespace equinox
{
    partial class admin
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addUser = new System.Windows.Forms.Button();
            this.UserID = new System.Windows.Forms.Label();
            this.PIN = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbSuffix = new System.Windows.Forms.TextBox();
            this.tbStreetAddress1 = new System.Windows.Forms.TextBox();
            this.tbStreetAddress2 = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.tbHomePhone = new System.Windows.Forms.TextBox();
            this.tbWorkPhone = new System.Windows.Forms.TextBox();
            this.tbCellPhone = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.lblStreetAddress1 = new System.Windows.Forms.Label();
            this.lblStreetAddress2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.lblWorkPhone = new System.Windows.Forms.Label();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(12, 54);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(26, 23);
            this.addUser.TabIndex = 2;
            this.addUser.Text = "Add User";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Location = new System.Drawing.Point(13, 14);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(40, 13);
            this.UserID.TabIndex = 3;
            this.UserID.Text = "UserID";
            // 
            // PIN
            // 
            this.PIN.AutoSize = true;
            this.PIN.Location = new System.Drawing.Point(13, 85);
            this.PIN.Name = "PIN";
            this.PIN.Size = new System.Drawing.Size(25, 13);
            this.PIN.TabIndex = 4;
            this.PIN.Text = "PIN";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(150, 30);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 6;
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbMiddleName.Location = new System.Drawing.Point(273, 30);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(100, 20);
            this.tbMiddleName.TabIndex = 7;
            this.tbMiddleName.TextChanged += new System.EventHandler(this.tbMiddlerName_TextChanged);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(399, 30);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 8;
            this.tbLastName.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // tbSuffix
            // 
            this.tbSuffix.Location = new System.Drawing.Point(522, 30);
            this.tbSuffix.Name = "tbSuffix";
            this.tbSuffix.Size = new System.Drawing.Size(100, 20);
            this.tbSuffix.TabIndex = 9;
            // 
            // tbStreetAddress1
            // 
            this.tbStreetAddress1.Location = new System.Drawing.Point(150, 80);
            this.tbStreetAddress1.Name = "tbStreetAddress1";
            this.tbStreetAddress1.Size = new System.Drawing.Size(252, 20);
            this.tbStreetAddress1.TabIndex = 10;
            // 
            // tbStreetAddress2
            // 
            this.tbStreetAddress2.Location = new System.Drawing.Point(418, 80);
            this.tbStreetAddress2.Name = "tbStreetAddress2";
            this.tbStreetAddress2.Size = new System.Drawing.Size(252, 20);
            this.tbStreetAddress2.TabIndex = 11;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(150, 125);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(193, 20);
            this.tbCity.TabIndex = 12;
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(349, 125);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(169, 20);
            this.tbState.TabIndex = 13;
            // 
            // tbZipCode
            // 
            this.tbZipCode.Location = new System.Drawing.Point(524, 125);
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(81, 20);
            this.tbZipCode.TabIndex = 14;
            // 
            // tbHomePhone
            // 
            this.tbHomePhone.Location = new System.Drawing.Point(150, 162);
            this.tbHomePhone.Name = "tbHomePhone";
            this.tbHomePhone.Size = new System.Drawing.Size(252, 20);
            this.tbHomePhone.TabIndex = 15;
            // 
            // tbWorkPhone
            // 
            this.tbWorkPhone.Location = new System.Drawing.Point(150, 198);
            this.tbWorkPhone.Name = "tbWorkPhone";
            this.tbWorkPhone.Size = new System.Drawing.Size(252, 20);
            this.tbWorkPhone.TabIndex = 16;
            // 
            // tbCellPhone
            // 
            this.tbCellPhone.Location = new System.Drawing.Point(150, 233);
            this.tbCellPhone.Name = "tbCellPhone";
            this.tbCellPhone.Size = new System.Drawing.Size(252, 20);
            this.tbCellPhone.TabIndex = 17;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(151, 14);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 18;
            this.lblFirstName.Text = "First Name";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(273, 14);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(69, 13);
            this.lblMiddleName.TabIndex = 19;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(399, 14);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 20;
            this.lblLastName.Text = "Last Name";
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Location = new System.Drawing.Point(521, 14);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(33, 13);
            this.lblSuffix.TabIndex = 21;
            this.lblSuffix.Text = "Suffix";
            this.lblSuffix.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblStreetAddress1
            // 
            this.lblStreetAddress1.AutoSize = true;
            this.lblStreetAddress1.Location = new System.Drawing.Point(151, 64);
            this.lblStreetAddress1.Name = "lblStreetAddress1";
            this.lblStreetAddress1.Size = new System.Drawing.Size(85, 13);
            this.lblStreetAddress1.TabIndex = 22;
            this.lblStreetAddress1.Text = "Street Address 1";
            // 
            // lblStreetAddress2
            // 
            this.lblStreetAddress2.AutoSize = true;
            this.lblStreetAddress2.Location = new System.Drawing.Point(418, 64);
            this.lblStreetAddress2.Name = "lblStreetAddress2";
            this.lblStreetAddress2.Size = new System.Drawing.Size(85, 13);
            this.lblStreetAddress2.TabIndex = 23;
            this.lblStreetAddress2.Text = "Street Address 2";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(151, 109);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 24;
            this.lblCity.Text = "City";
            this.lblCity.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(349, 109);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 25;
            this.lblState.Text = "State";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(524, 109);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(50, 13);
            this.lblZipCode.TabIndex = 26;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(151, 148);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(69, 13);
            this.lblHomePhone.TabIndex = 27;
            this.lblHomePhone.Text = "Home Phone";
            this.lblHomePhone.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblWorkPhone
            // 
            this.lblWorkPhone.AutoSize = true;
            this.lblWorkPhone.Location = new System.Drawing.Point(151, 184);
            this.lblWorkPhone.Name = "lblWorkPhone";
            this.lblWorkPhone.Size = new System.Drawing.Size(67, 13);
            this.lblWorkPhone.TabIndex = 28;
            this.lblWorkPhone.Text = "Work Phone";
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Location = new System.Drawing.Point(151, 219);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(58, 13);
            this.lblCellPhone.TabIndex = 29;
            this.lblCellPhone.Text = "Cell Phone";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(418, 162);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(252, 20);
            this.tbEmail.TabIndex = 30;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(419, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(33, 13);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "EMail";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(44, 54);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(26, 23);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(116, 29);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(27, 23);
            this.btnFind.TabIndex = 34;
            this.btnFind.Text = "F";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::equinox.Properties.Resources.moon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(677, 270);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblCellPhone);
            this.Controls.Add(this.lblWorkPhone);
            this.Controls.Add(this.lblHomePhone);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreetAddress2);
            this.Controls.Add(this.lblStreetAddress1);
            this.Controls.Add(this.lblSuffix);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.tbCellPhone);
            this.Controls.Add(this.tbWorkPhone);
            this.Controls.Add(this.tbHomePhone);
            this.Controls.Add(this.tbZipCode);
            this.Controls.Add(this.tbState);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbStreetAddress2);
            this.Controls.Add(this.tbStreetAddress1);
            this.Controls.Add(this.tbSuffix);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbMiddleName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.PIN);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "admin";
            this.Text = "User Administration";
            this.Load += new System.EventHandler(this.admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label PIN;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbSuffix;
        private System.Windows.Forms.TextBox tbStreetAddress1;
        private System.Windows.Forms.TextBox tbStreetAddress2;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.TextBox tbZipCode;
        private System.Windows.Forms.TextBox tbHomePhone;
        private System.Windows.Forms.TextBox tbWorkPhone;
        private System.Windows.Forms.TextBox tbCellPhone;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.Label lblStreetAddress1;
        private System.Windows.Forms.Label lblStreetAddress2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.Label lblWorkPhone;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
    }
}