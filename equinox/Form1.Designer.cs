namespace equinox
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.idText = new System.Windows.Forms.Label();
            this.idPin = new System.Windows.Forms.Label();
            this.authenticate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(0, 27);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(100, 50);
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // idText
            // 
            this.idText.AutoSize = true;
            this.idText.Location = new System.Drawing.Point(118, 33);
            this.idText.Name = "idText";
            this.idText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.idText.Size = new System.Drawing.Size(18, 13);
            this.idText.TabIndex = 4;
            this.idText.Text = "ID";
            this.idText.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // idPin
            // 
            this.idPin.AutoSize = true;
            this.idPin.Location = new System.Drawing.Point(118, 57);
            this.idPin.Name = "idPin";
            this.idPin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.idPin.Size = new System.Drawing.Size(25, 13);
            this.idPin.TabIndex = 5;
            this.idPin.Text = "PIN";
            this.idPin.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // authenticate
            // 
            this.authenticate.Location = new System.Drawing.Point(166, 89);
            this.authenticate.Name = "authenticate";
            this.authenticate.Size = new System.Drawing.Size(100, 23);
            this.authenticate.TabIndex = 6;
            this.authenticate.Text = "Login";
            this.authenticate.UseVisualStyleBackColor = true;
            this.authenticate.Click += new System.EventHandler(this.authenticate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::equinox.Properties.Resources.moon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(292, 134);
            this.Controls.Add(this.authenticate);
            this.Controls.Add(this.idPin);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Equinox Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label idText;
        private System.Windows.Forms.Label idPin;
        private System.Windows.Forms.Button authenticate;
    }
}

