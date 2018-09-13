using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace equinox
{
    public partial class Form1 : Form
    {
        //public string customerid;

        public Form1()
        {
            InitializeComponent();
}

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void authenticate_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "institution")
            {
                institution institutionNew = new institution();
                logEm(this.textBox1.Text + " jump to institution screen", this.textBox1.Text);
                institutionNew.Show();

            }

            if (this.textBox1.Text == "mail")
            {
                mailsimple mailNew = new mailsimple();
                logEm(this.textBox1.Text + " jump to institution screen", this.textBox1.Text);
                mailNew.Show();

            }

            if (this.textBox1.Text == "admin")
            {
                admin adminActive = new admin();
                logEm(this.textBox1.Text + " jump to admin screen", this.textBox1.Text);
                adminActive.Show();
            }
            else
            {
                equinox_data_access maintaindata = new equinox_data_access();
                string outcome = maintaindata.e_customer_authenticate("1", "A", this.textBox1.Text, this.textBox2.Text);

                if (outcome == "True")
                {
                    logEm(this.textBox1.Text + " has successfully logged in", this.textBox1.Text);
                    Acct acctActive = new Acct(this.textBox1.Text); //pass username to fill the following form!
                    acctActive.Show();
                }
                if (outcome == "False")
                {
                    this.textBox1.Text = "Try Again";
                    this.textBox2.Text = "";
                }
                if (outcome == "ToMany")
                {
                    this.textBox1.Text = "To Many";
                    this.textBox2.Text = "";
                }
            }
        }

        private void callBankInfo(object sender, EventArgs e)
        {

        }
        private void logEm(string logEntryPass, string customerid)
        {
            // this will take a string and post it along with the time and date to the e_log table

            String ConnectionString;
            String sqlcommand;

                     try
                        {


                            ConnectionString = "data source=localhost;uid=sa;password=;database=equinox";
                            SqlConnection cn = new SqlConnection(ConnectionString);
                            cn.Open();

                            sqlcommand = "insert into e_log(customerid, logdate, logentry) values(@customerid, @logdate, @logentry)";
                
                            SqlCommand mySqlCommand = cn.CreateCommand();
                            mySqlCommand.CommandText = sqlcommand;

                            // build and assign the log entry event
                            mySqlCommand.Parameters.Add("@customerid", SqlDbType.VarChar, 50);
                            mySqlCommand.Parameters.Add("@logdate", SqlDbType.VarChar, 50);
                            mySqlCommand.Parameters.Add("@logentry", SqlDbType.VarChar, 1800);

                            //assign data
                            mySqlCommand.Parameters["@customerid"].Value = customerid.ToString();
                            mySqlCommand.Parameters["@logdate"].Value = System.DateTime.Today.ToString();
                            mySqlCommand.Parameters["@logentry"].Value = logEntryPass.ToString();
                
                            mySqlCommand.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show(this, "error - logevent failure", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_picture();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void load_picture()
        {
            SqlDataReader rdr = null;

            String ConnectionString;
            String sqlcommand;

            ConnectionString = "data source=localhost;uid=sa;password=;database=equinox";
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();

            SqlCommand mySqlCommand = cn.CreateCommand();

            // find user
            sqlcommand = "select * from e_institution where inumber like @inumber";

            mySqlCommand.CommandText = sqlcommand;
            // build 
            mySqlCommand.Parameters.Add("@inumber", SqlDbType.Decimal, 9);

            //assign data
            mySqlCommand.Parameters["@inumber"].Value = "1";

            rdr = mySqlCommand.ExecuteReader();

            while (rdr.Read())
            {
                //this.tbInumber.Text = rdr["inumber"].ToString();
                //this.tbIname.Text = rdr["iname"].ToString();

                string getithere = rdr["ilogo"].ToString();
                this.pbLogo.Image = Image.FromFile(@getithere);
             }
        }
    }
}
