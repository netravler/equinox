namespace equinox
{
    partial class Acct
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.actInfo = new System.Windows.Forms.ListBox();
            this.transactionType = new System.Windows.Forms.ListBox();
            this.customerInformation = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(784, 159);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(784, 188);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // actInfo
            // 
            this.actInfo.FormattingEnabled = true;
            this.actInfo.Location = new System.Drawing.Point(28, 267);
            this.actInfo.Name = "actInfo";
            this.actInfo.Size = new System.Drawing.Size(208, 433);
            this.actInfo.TabIndex = 6;
            this.actInfo.Tag = "actInfo";
            // 
            // transactionType
            // 
            this.transactionType.FormattingEnabled = true;
            this.transactionType.Location = new System.Drawing.Point(724, 37);
            this.transactionType.Name = "transactionType";
            this.transactionType.Size = new System.Drawing.Size(260, 108);
            this.transactionType.TabIndex = 7;
            this.transactionType.Tag = "transactionType";
            // 
            // customerInformation
            // 
            this.customerInformation.FormattingEnabled = true;
            this.customerInformation.Location = new System.Drawing.Point(28, 37);
            this.customerInformation.Name = "customerInformation";
            this.customerInformation.Size = new System.Drawing.Size(679, 212);
            this.customerInformation.TabIndex = 8;
            this.customerInformation.Tag = "customerInformation\'";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(264, 267);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(720, 433);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Acct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::equinox.Properties.Resources.moon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 729);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.customerInformation);
            this.Controls.Add(this.transactionType);
            this.Controls.Add(this.actInfo);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Acct";
            this.Text = "Customer Accounts";
            this.Load += new System.EventHandler(this.Acct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ListBox actInfo;
        private System.Windows.Forms.ListBox transactionType;
        private System.Windows.Forms.ListBox customerInformation;
        private System.Windows.Forms.ListBox listBox1;
    }
}