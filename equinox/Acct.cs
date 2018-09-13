using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace equinox
{
    public partial class Acct : Form
    {
        private String ConnectionString;

        public Acct(string initialvalue)
        {
            InitializeComponent();

            string holdit = initialvalue;
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            String catstring = "";
            String sqlcommand = "";

            // setup db-connection
            try
            {
                ConnectionString = "data source=localhost;uid=sa;password=;database=equinox";
                SqlConnection cn = new SqlConnection(ConnectionString);
                cn.Open();

                sqlcommand = "Select * from e_transactions where customerid = '";
                sqlcommand = sqlcommand + holdit + "'";

                SqlDataAdapter transactions_1 = new SqlDataAdapter(sqlcommand, cn);
                transactions_1.Fill(dt);

                // Loop through all entries
                foreach (DataRow drRow in dt.Rows)
                {
                foreach (var item in drRow.ItemArray)
                    {
                        catstring = catstring + item + " ";
                    }
                    listBox1.Items.Add(catstring);
                    catstring = "";
                }

            }
            catch
            {
                MessageBox.Show(this, "error - open ErrorMessage data source=localhost;uid=sa;password=;database=equinox", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Acct_Load(object sender, EventArgs e)
        {
            

        }
    }
}
