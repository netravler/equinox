namespace equinox
{
    partial class institution
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tbInumber = new System.Windows.Forms.TextBox();
            this.tbIname = new System.Windows.Forms.TextBox();
            this.tbIdatecreated = new System.Windows.Forms.TextBox();
            this.tbIdatedeleted = new System.Windows.Forms.TextBox();
            this.tbInote = new System.Windows.Forms.RichTextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.lblDateDeleted = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnCreateUpdate = new System.Windows.Forms.Button();
            this.pbIlogo = new System.Windows.Forms.PictureBox();
            this.tbImagePath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(366, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tbInumber
            // 
            this.tbInumber.Location = new System.Drawing.Point(12, 52);
            this.tbInumber.Name = "tbInumber";
            this.tbInumber.Size = new System.Drawing.Size(100, 20);
            this.tbInumber.TabIndex = 1;
            // 
            // tbIname
            // 
            this.tbIname.Location = new System.Drawing.Point(12, 94);
            this.tbIname.Name = "tbIname";
            this.tbIname.Size = new System.Drawing.Size(326, 20);
            this.tbIname.TabIndex = 2;
            this.tbIname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbIdatecreated
            // 
            this.tbIdatecreated.Location = new System.Drawing.Point(12, 191);
            this.tbIdatecreated.Name = "tbIdatecreated";
            this.tbIdatecreated.Size = new System.Drawing.Size(100, 20);
            this.tbIdatecreated.TabIndex = 4;
            // 
            // tbIdatedeleted
            // 
            this.tbIdatedeleted.Location = new System.Drawing.Point(12, 233);
            this.tbIdatedeleted.Name = "tbIdatedeleted";
            this.tbIdatedeleted.Size = new System.Drawing.Size(100, 20);
            this.tbIdatedeleted.TabIndex = 5;
            // 
            // tbInote
            // 
            this.tbInote.Location = new System.Drawing.Point(12, 283);
            this.tbInote.Name = "tbInote";
            this.tbInote.Size = new System.Drawing.Size(326, 192);
            this.tbInote.TabIndex = 6;
            this.tbInote.Text = "";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(13, 36);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(44, 13);
            this.lblNumber.TabIndex = 7;
            this.lblNumber.Text = "Number";
            this.lblNumber.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(13, 121);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(31, 13);
            this.lblLogo.TabIndex = 9;
            this.lblLogo.Text = "Logo";
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Location = new System.Drawing.Point(13, 175);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(70, 13);
            this.lblDateCreated.TabIndex = 10;
            this.lblDateCreated.Text = "Date Created";
            // 
            // lblDateDeleted
            // 
            this.lblDateDeleted.AutoSize = true;
            this.lblDateDeleted.Location = new System.Drawing.Point(12, 218);
            this.lblDateDeleted.Name = "lblDateDeleted";
            this.lblDateDeleted.Size = new System.Drawing.Size(70, 13);
            this.lblDateDeleted.TabIndex = 11;
            this.lblDateDeleted.Text = "Date Deleted";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(14, 269);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(30, 13);
            this.lblNote.TabIndex = 12;
            this.lblNote.Text = "Note";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(131, 49);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(101, 23);
            this.btnFind.TabIndex = 13;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnCreateUpdate
            // 
            this.btnCreateUpdate.Location = new System.Drawing.Point(238, 49);
            this.btnCreateUpdate.Name = "btnCreateUpdate";
            this.btnCreateUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnCreateUpdate.TabIndex = 14;
            this.btnCreateUpdate.Text = "Create/Update";
            this.btnCreateUpdate.UseVisualStyleBackColor = true;
            this.btnCreateUpdate.Click += new System.EventHandler(this.btnCreateUpdate_Click);
            // 
            // pbIlogo
            // 
            this.pbIlogo.Image = global::equinox.Properties.Resources.placeholder;
            this.pbIlogo.Location = new System.Drawing.Point(210, 137);
            this.pbIlogo.Name = "pbIlogo";
            this.pbIlogo.Size = new System.Drawing.Size(128, 116);
            this.pbIlogo.TabIndex = 15;
            this.pbIlogo.TabStop = false;
            this.pbIlogo.Click += new System.EventHandler(this.pbIlogo_Click);
            // 
            // tbImagePath
            // 
            this.tbImagePath.Location = new System.Drawing.Point(12, 137);
            this.tbImagePath.Name = "tbImagePath";
            this.tbImagePath.Size = new System.Drawing.Size(181, 20);
            this.tbImagePath.TabIndex = 16;
            this.tbImagePath.TextChanged += new System.EventHandler(this.tbImagePath_TextChanged);
            // 
            // institution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::equinox.Properties.Resources.moon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(366, 497);
            this.Controls.Add(this.tbImagePath);
            this.Controls.Add(this.pbIlogo);
            this.Controls.Add(this.btnCreateUpdate);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblDateDeleted);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.tbInote);
            this.Controls.Add(this.tbIdatedeleted);
            this.Controls.Add(this.tbIdatecreated);
            this.Controls.Add(this.tbIname);
            this.Controls.Add(this.tbInumber);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "institution";
            this.Text = "Institution Control";
            this.Load += new System.EventHandler(this.institution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox tbInumber;
        private System.Windows.Forms.TextBox tbIname;
        private System.Windows.Forms.TextBox tbIdatecreated;
        private System.Windows.Forms.TextBox tbIdatedeleted;
        private System.Windows.Forms.RichTextBox tbInote;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.Label lblDateDeleted;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnCreateUpdate;
        private System.Windows.Forms.PictureBox pbIlogo;
        private System.Windows.Forms.TextBox tbImagePath;
    }
}