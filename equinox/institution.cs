using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace equinox
{
    public partial class institution : Form
    {
        public institution()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void institution_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
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
            mySqlCommand.Parameters.Add("@iname", SqlDbType.VarChar, 120);
            mySqlCommand.Parameters.Add("@ilogo", SqlDbType.VarChar, 80);
            //mySqlCommand.Parameters.Add("@idatecreated", SqlDbType.DateTime, 8);
            //mySqlCommand.Parameters.Add("@idatedeleted", SqlDbType.DateTime, 8);
            mySqlCommand.Parameters.Add("@inote", SqlDbType.VarChar, 500);
            //assign data
            mySqlCommand.Parameters["@inumber"].Value = this.tbInumber.Text;
            mySqlCommand.Parameters["@iname"].Value = this.tbIname.Text;
            mySqlCommand.Parameters["@ilogo"].Value = this.tbImagePath.Text;
            //mySqlCommand.Parameters["@idatecreated"].Value = this.tbIdatecreated.Text;
            //mySqlCommand.Parameters["@idatedeleted"].Value = this.tbIdatedeleted.Text;
            mySqlCommand.Parameters["@inote"].Value = this.tbInote.Text;

            rdr = mySqlCommand.ExecuteReader();

            while (rdr.Read())
            {
                this.tbInumber.Text = rdr["inumber"].ToString();
                this.tbIname.Text = rdr["iname"].ToString();
                this.tbImagePath.Text = rdr["ilogo"].ToString();
                // fill the picturebox
                string getithere = this.tbImagePath.Text;
                this.pbIlogo.Image = Image.FromFile(@getithere); 
               // this.tbIdatecreated.Text = rdr["idatecreated"].ToString();
               // this.tbIdatedeleted.Text = rdr["idatedeleted"].ToString();
                this.tbInote.Text = rdr["inote"].ToString();
            }
        }

        private void btnCreateUpdate_Click(object sender, EventArgs e)
        {
            String ConnectionString;
            String sqlcommand;
            try
            {
                ConnectionString = "data source=localhost;uid=sa;password=;database=equinox";
                SqlConnection cn = new SqlConnection(ConnectionString);
                cn.Open();

                SqlCommand mySqlCommand = cn.CreateCommand();

                // 
                sqlcommand = "insert into e_customers(inumber, iname, ilogo, idatecreated, idatedeleted, inote) values(@inumber, @iname, @ilogo, @idatecreated, @datedeleted, @inote)";
                mySqlCommand.CommandText = sqlcommand;
                // build 
                mySqlCommand.Parameters.Add("@inumber", SqlDbType.VarChar, 10);
                mySqlCommand.Parameters.Add("@iname", SqlDbType.VarChar, 50);
                mySqlCommand.Parameters.Add("@ilogo", SqlDbType.VarChar, 128);
                mySqlCommand.Parameters.Add("@idatecreated", SqlDbType.VarChar, 25);
                mySqlCommand.Parameters.Add("@idatedeleted", SqlDbType.VarChar, 50);
                mySqlCommand.Parameters.Add("@inote", SqlDbType.VarChar, 50);

                //assign data
                mySqlCommand.Parameters["@inumber"].Value = this.tbInumber.Text;
                mySqlCommand.Parameters["@iname"].Value = this.tbIname.Text;
                mySqlCommand.Parameters["@ilogo"].Value = this.tbImagePath.Text;
                mySqlCommand.Parameters["@idatecreated"].Value = this.tbIdatecreated.Text;
                mySqlCommand.Parameters["@idatedeleted"].Value = this.tbIdatedeleted.Text;
                mySqlCommand.Parameters["@inote"].Value = this.lblNote.Text;

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
                sqlcommand = "update e_institution set inumber=@inumber, iname=@iname, idatecreated=@idatecreated, idatedeleted=@idatedeleted, inote=@inote";
                mySqlCommand.CommandText = sqlcommand;
                // build 
                mySqlCommand.Parameters.Add("@inumber", SqlDbType.VarChar, 10);
                mySqlCommand.Parameters.Add("@iname", SqlDbType.VarChar, 50);
                mySqlCommand.Parameters.Add("@ilogo", SqlDbType.VarChar, 128);
                mySqlCommand.Parameters.Add("@idatecreated", SqlDbType.VarChar, 25);
                mySqlCommand.Parameters.Add("@idatedeleted", SqlDbType.VarChar, 50);
                mySqlCommand.Parameters.Add("@inote", SqlDbType.VarChar, 50);

                //assign data
                mySqlCommand.Parameters["@inumber"].Value = this.tbInumber.Text;
                mySqlCommand.Parameters["@iname"].Value = this.tbIname.Text;
                mySqlCommand.Parameters["@ilogo"].Value = this.tbImagePath.Text;
                mySqlCommand.Parameters["@idatecreated"].Value = this.tbIdatecreated.Text;
                mySqlCommand.Parameters["@idatedeleted"].Value = this.tbIdatedeleted.Text;
                mySqlCommand.Parameters["@inote"].Value = this.tbInote.Text;

                mySqlCommand.CommandText = sqlcommand;
                mySqlCommand.ExecuteNonQuery();
            }
        }

        //Open file in to a filestream and read data in a byte array.
        byte[] ReadFile(string sPath)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes to read from file.
            //In this case we want to read entire file. So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);
            return data;
        }

        private void pbIlogo_Click(object sender, EventArgs e)
        {
            string getithere = this.tbImagePath.Text;
            this.pbIlogo.Image = Image.FromFile(@getithere); 
        }

        private void tbImagePath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
