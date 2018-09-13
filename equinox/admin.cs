using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace equinox
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            hashem comparemeplease = new hashem();

            String ConnectionString;
            String sqlcommand;
            try
            {
                ConnectionString = "data source=localhost;uid=sa;password=;database=equinox";
                SqlConnection cn = new SqlConnection(ConnectionString);
                cn.Open();

                SqlCommand mySqlCommand = cn.CreateCommand();

                // 
                sqlcommand = "insert into e_customers(fi, customerid, pin, firstname, middlename, lastname, suffix, streetaddress1, streetaddress2, city, state, zipcode, homephone, workphone, cellphone, email) values(@fi, @customerid, @pin, @firstname, @middlename, @lastname, @suffix, @streetaddress1, @streetaddress2, @city, @state, @zipcode, @homephone, @workphone, @cellphone, @email)";
                mySqlCommand.CommandText = sqlcommand;
                // build 
                mySqlCommand.Parameters.Add("@fi", SqlDbType.VarChar, 10);
                mySqlCommand.Parameters.Add("@customerid", SqlDbType.VarChar, 50);
                mySqlCommand.Parameters.Add("@pin", SqlDbType.VarChar, 128);
                mySqlCommand.Parameters.Add("@firstname", SqlDbType.VarChar, 25);
                mySqlCommand.Parameters.Add("@middlename", SqlDbType.VarChar, 50);
                mySqlCommand.Parameters.Add("@lastname", SqlDbType.VarChar, 50);
                mySqlCommand.Parameters.Add("@suffix", SqlDbType.VarChar, 50);
                mySqlCommand.Parameters.Add("@streetaddress1", SqlDbType.VarChar, 10);
                mySqlCommand.Parameters.Add("@streetaddress2", SqlDbType.VarChar, 50);
                mySqlCommand.Parameters.Add("@city", SqlDbType.VarChar, 50);
                mySqlCommand.Parameters.Add("@state", SqlDbType.VarChar, 50);
                mySqlCommand.Parameters.Add("@zipcode", SqlDbType.VarChar, 50);
                mySqlCommand.Parameters.Add("@homephone", SqlDbType.VarChar, 10);
                mySqlCommand.Parameters.Add("@workphone", SqlDbType.VarChar, 25);
                mySqlCommand.Parameters.Add("@cellphone", SqlDbType.VarChar, 25);
                mySqlCommand.Parameters.Add("@email", SqlDbType.VarChar, 45);
                //assign data
                mySqlCommand.Parameters["@fi"].Value = 1;
                mySqlCommand.Parameters["@customerid"].Value = this.textBox1.Text;
                mySqlCommand.Parameters["@pin"].Value = comparemeplease.makeHash(this.textBox2.Text);
                mySqlCommand.Parameters["@firstname"].Value = tbFirstName.Text;
                mySqlCommand.Parameters["@middlename"].Value = tbMiddleName.Text;
                mySqlCommand.Parameters["@lastname"].Value = tbLastName.Text;
                mySqlCommand.Parameters["@suffix"].Value = tbSuffix.Text;
                mySqlCommand.Parameters["@streetaddress1"].Value = tbStreetAddress1.Text;
                mySqlCommand.Parameters["@streetaddress2"].Value = tbStreetAddress2.Text;
                mySqlCommand.Parameters["@city"].Value = tbCity.Text;
                mySqlCommand.Parameters["@state"].Value = tbState.Text;
                mySqlCommand.Parameters["@zipcode"].Value = tbZipCode.Text;
                mySqlCommand.Parameters["@homephone"].Value = tbHomePhone.Text;
                mySqlCommand.Parameters["@workphone"].Value = tbWorkPhone.Text;
                mySqlCommand.Parameters["@cellphone"].Value = tbCellPhone.Text;
                mySqlCommand.Parameters["@email"].Value = tbEmail.Text;

                mySqlCommand.CommandText = sqlcommand;
                mySqlCommand.ExecuteNonQuery();
            }
            catch  // assume update!
            {
                ConnectionString = "data source=localhost;uid=sa;password=;database=equinox";
                SqlConnection cn = new SqlConnection(ConnectionString);
                cn.Open();

                SqlCommand mySqlCommand = cn.CreateCommand();

                // 
                sqlcommand = "update e_customers set pin=@pin, firstname=@firstname, middlename=@middlename, lastname=@lastname, suffix=@suffix, streetaddress1=@streetaddress1, streetaddress2=@streetaddress2, city=@city, state=@state, zipcode=@zipcode, homephone=@homephone, workphone=@workphone, cellphone=@cellphone, email=@email where fi=@fi and customerid=@customerid";
                mySqlCommand.CommandText = sqlcommand;
                // build 
                mySqlCommand.Parameters.Add("@fi", SqlDbType.VarChar, 10);
                mySqlCommand.Parameters.Add("@customerid", SqlDbType.VarChar, 50);
                mySqlCommand.Parameters.Add("@pin", SqlDbType.VarChar, 128);
                mySqlCommand.Parameters.Add("@firstname", SqlDbType.VarChar, 25);
                mySqlCommand.Parameters.Add("@middlename", SqlDbType.VarChar, 50);
                mySqlCommand.Parameters.Add("@lastname", SqlDbType.VarChar, 50);
                mySqlCommand.Parameters.Add("@suffix", SqlDbType.VarChar, 50);
                mySqlCommand.Parameters.Add("@streetaddress1", SqlDbType.VarChar, 10);
                mySqlCommand.Parameters.Add("@streetaddress2", SqlDbType.VarChar, 50);
                mySqlCommand.Parameters.Add("@city", SqlDbType.VarChar, 50);
                mySqlCommand.Parameters.Add("@state", SqlDbType.VarChar, 50);
                mySqlCommand.Parameters.Add("@zipcode", SqlDbType.VarChar, 50);
                mySqlCommand.Parameters.Add("@homephone", SqlDbType.VarChar, 10);
                mySqlCommand.Parameters.Add("@workphone", SqlDbType.VarChar, 25);
                mySqlCommand.Parameters.Add("@cellphone", SqlDbType.VarChar, 25);
                mySqlCommand.Parameters.Add("@email", SqlDbType.VarChar, 45);
                //assign data
                mySqlCommand.Parameters["@fi"].Value = 1;
                mySqlCommand.Parameters["@customerid"].Value = this.textBox1.Text;
                mySqlCommand.Parameters["@pin"].Value = comparemeplease.makeHash(this.textBox2.Text);
                mySqlCommand.Parameters["@firstname"].Value = tbFirstName.Text;
                mySqlCommand.Parameters["@middlename"].Value = tbMiddleName.Text;
                mySqlCommand.Parameters["@lastname"].Value = tbLastName.Text;
                mySqlCommand.Parameters["@suffix"].Value = tbSuffix.Text;
                mySqlCommand.Parameters["@streetaddress1"].Value = tbStreetAddress1.Text;
                mySqlCommand.Parameters["@streetaddress2"].Value = tbStreetAddress2.Text;
                mySqlCommand.Parameters["@city"].Value = tbCity.Text;
                mySqlCommand.Parameters["@state"].Value = tbState.Text;
                mySqlCommand.Parameters["@zipcode"].Value = tbZipCode.Text;
                mySqlCommand.Parameters["@homephone"].Value = tbHomePhone.Text;
                mySqlCommand.Parameters["@workphone"].Value = tbWorkPhone.Text;
                mySqlCommand.Parameters["@cellphone"].Value = tbCellPhone.Text;
                mySqlCommand.Parameters["@email"].Value = tbEmail.Text;

                mySqlCommand.CommandText = sqlcommand;
                mySqlCommand.ExecuteNonQuery();               
            }
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            equinox_data_access accessinfo = new equinox_data_access("1","A",this.textBox1.Text,this.textBox2.Text,"","","","","","","");

            hashem comparemeplease = new hashem();
            SqlDataReader rdr = null;

            String ConnectionString;
            String sqlcommand;

            ConnectionString = "data source=localhost;uid=sa;password=;database=equinox";
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();

            SqlCommand mySqlCommand = cn.CreateCommand();

            // find user
            sqlcommand = "select * from e_customers where customerid=@customerid and fi=@fi";

            mySqlCommand.CommandText = sqlcommand;
            // build 
            mySqlCommand.Parameters.Add("@fi", SqlDbType.VarChar, 10);
            mySqlCommand.Parameters.Add("@customerid", SqlDbType.VarChar, 50);
            mySqlCommand.Parameters.Add("@pin", SqlDbType.VarChar, 128);
            //assign data
            mySqlCommand.Parameters["@fi"].Value = 1;
            mySqlCommand.Parameters["@customerid"].Value = this.textBox1.Text;
            mySqlCommand.Parameters["@pin"].Value = comparemeplease.makeHash(this.textBox2.Text);

            rdr = mySqlCommand.ExecuteReader();

            while(rdr.Read())
                {
                  tbFirstName.Text = rdr["firstName"].ToString();
                  tbLastName.Text = rdr["lastname"].ToString();
                  tbMiddleName.Text = rdr["middlename"].ToString();
                  tbStreetAddress1.Text = rdr["streetaddress1"].ToString();
                  tbStreetAddress2.Text = rdr["streetaddress2"].ToString();
                  tbSuffix.Text = rdr["suffix"].ToString();
                  tbCity.Text = rdr["city"].ToString();
                  tbState.Text = rdr["state"].ToString();
                  tbZipCode.Text = rdr["zipcode"].ToString();
                  tbHomePhone.Text = rdr["homephone"].ToString();
                  tbWorkPhone.Text = rdr["workphone"].ToString();
                  tbCellPhone.Text = rdr["cellphone"].ToString();
                  tbEmail.Text = rdr["email"].ToString();
                  textBox2.Text = rdr["pin"].ToString();
                }
        }

        private void tbMiddlerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
