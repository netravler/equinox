using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Mail;
using System.Configuration;


namespace equinox
{
    public class equinox_data_access
    {
        private string database;
        private string table;
        private string updatestring;
        private string deletestring;
        private string fi;
        private string dothis;
        private string customerid;
        private string pin;
        private string institution;
        private int associated;
        private string email;
        private string firstname;
        private string middlename;
        private string lastname;
        private string role;

        public equinox_data_access() { }

        //public equinox_data_access(string database, string table, string updatestring, string deletestring)
        public string equinox_data_access(string fi, string dothis, string customerid, string pin, string institution, int associated, string email, string firstname, string middlename, string lastname, string role)
        {
            this.Database = database;
            this.Table = table;
            this.Updatestring = updatestring;
            this.Deletestring = deletestring;
            this.Fi = fi;
            this.DoThis = dothis;
            this.Customerid = customerid;
            this.Pin = pin;
            this.Insitution = institution;
            this.Associated = associated;
            this.Email = email;
            this.Firstname = firstname;
            this.Middlename = middlename;
            this.Lastname = lastname;
            this.Role = role;
        }

          public string Database
          {
                get
                {
                    return database;
                }
                set 
                {
                    database = value;
                }
          }

           public string Table
           {
                get
                {
                    return table;
                }
                set  
                {
                    table = value;
                }
           }
                
           public string Updatestring
           {
                get
                {
                    return updatestring;
                }
                set  
                {
                    updatestring = value;
                }
           }

           public string Deletestring
           {
               get
               {
                   return deletestring;
               }
               set
               {
                   deletestring = value;
               }
           }
    

           public void equinox_data_access(string fi, string dothis, string customerid, string pin, string institution, int associated, string email, string firstname, string middlename, string lastname, string role)
           {
                //private string fi;
                //private string dothis;
                //private string customerid;
                //private string pin;
                //private string institution;
                //private int associated;
                //private string email;
                //private string firstname;
                //private string middlename;
                //private string lastname;
                //private string role;

                string outcome = database_processing(fi, dothis, customerid, pin, "", 0, "", "", "", "", "");

                //return "";
  
           }
        
           private string database_processing(string fi, string dothis, string customerid, string pin, string institution, int associated, string email, string firstname, string middlename, string lastname, string role)
           {
               DataTable dt = new DataTable();
               DataSet ds = new DataSet();

               hashem comparemeplease = new hashem();
               string hashcompare = comparemeplease.makeHash(pin);

               // construct a call to e_customers 

               String ConnectionString;
               String sqlcommand;

               try 
               {
                   ConnectionString = "data source=localhost;uid=sa;password=;database=equinox";
                   SqlConnection cn = new SqlConnection(ConnectionString);
                   cn.Open();

                   SqlCommand mySqlCommand = cn.CreateCommand();

                   switch (dothis)
                   {
                       case "a": // add a record

                           sqlcommand = "insert into e_customers(fi, customerid, pin, institution, associated, email, firstname, middlename, lastname, role) values(@fi, @customerid, @pin, @institution, @associated, @email, @firstname, @middlename, @lastname, @role)";
                           mySqlCommand.CommandText = sqlcommand;
                           // build 
                           mySqlCommand.Parameters.Add("@fi",SqlDbType.VarChar, 10);
                           mySqlCommand.Parameters.Add("@customerid", SqlDbType.VarChar, 50);
                           mySqlCommand.Parameters.Add("@pin", SqlDbType.VarChar, 128);
                           mySqlCommand.Parameters.Add("@institution", SqlDbType.VarChar, 50);
                           mySqlCommand.Parameters.Add("@associated",SqlDbType.Int, 9);
                           mySqlCommand.Parameters.Add("@email", SqlDbType.VarChar, 45);
                           mySqlCommand.Parameters.Add("@firstname", SqlDbType.VarChar, 25);
                           mySqlCommand.Parameters.Add("@middlename", SqlDbType.VarChar, 50);
                           mySqlCommand.Parameters.Add("@lastname", SqlDbType.VarChar, 50);
                           mySqlCommand.Parameters.Add("@role", SqlDbType.VarChar, 10);

                           //assign data
                           mySqlCommand.Parameters["@fi"].Value = fi;
                           mySqlCommand.Parameters["@customerid"].Value = customerid;
                           mySqlCommand.Parameters["@pin"].Value = hashcompare;
                           mySqlCommand.Parameters["@institution"].Value = 1;
                           mySqlCommand.Parameters["@associated"].Value = associated;
                           mySqlCommand.Parameters["@email"].Value = email;
                           mySqlCommand.Parameters["@firstname"].Value = firstname;
                           mySqlCommand.Parameters["@middlename"].Value = middlename;
                           mySqlCommand.Parameters["@lastname"].Value = lastname;
                           mySqlCommand.Parameters["@role"].Value = role;

                           mySqlCommand.CommandText = sqlcommand;
                           mySqlCommand.ExecuteNonQuery();
     
                           break;

                       case "u": // update existing record

                           sqlcommand = "update e_customers set fi = @fi, customerid = @customerid, pin = @pin, institution = @institution, ";

                           if (associated != 0)
                           {
                               sqlcommand = sqlcommand + "associated = @associated, ";
                           }

                           if (email != "")
                           {
                               sqlcommand = sqlcommand + "email = @email, ";
                           }

                           if (firstname != "")
                           {
                               sqlcommand = sqlcommand + "firstname = @firstname, ";
                           }

                           if (middlename != "")
                           {
                               sqlcommand = sqlcommand + "middlename = @middlename, ";
                           }

                           if (lastname != "")
                           {
                               sqlcommand = sqlcommand + "lastname = @lastname, ";
                           }

                           if (role != "")
                           {
                               sqlcommand = sqlcommand + "role = @role, ";
                           }

                           mySqlCommand.CommandText = sqlcommand;

                           //sqlcommand = "update e_customers set customerid, pin, institution, associated, email, firstname, middlename, lastname values(@fi, @customerid, @pin, @institution, @associated, @email, @firstname, @middlename, @lastname where ";

                           // build 
                           //assign data
                           mySqlCommand.Parameters.Add("@fi", SqlDbType.VarChar, 10);
                           mySqlCommand.Parameters["@fi"].Value = fi;
                           mySqlCommand.Parameters.Add("@customerid", SqlDbType.VarChar, 50);
                           mySqlCommand.Parameters["@customerid"].Value = customerid;
                           mySqlCommand.Parameters.Add("@pin", SqlDbType.VarChar, 128);
                           mySqlCommand.Parameters["@pin"].Value = hashcompare;
                           mySqlCommand.Parameters.Add("@institution", SqlDbType.VarChar, 50);
                           mySqlCommand.Parameters["@institution"].Value = fi;

                           if (associated != 0)
                           {
                               mySqlCommand.Parameters.Add("@associated", SqlDbType.Int, 9);
                               mySqlCommand.Parameters["@associated"].Value = associated;
                           }

                           if (email != "")
                           {
                               mySqlCommand.Parameters.Add("@email", SqlDbType.VarChar, 45);
                               mySqlCommand.Parameters["@email"].Value = email;
                           }

                           if (middlename != "")
                           {
                               mySqlCommand.Parameters.Add("@firstname", SqlDbType.VarChar, 25);
                               mySqlCommand.Parameters["@firstname"].Value = firstname;
                           }

                           if (middlename != "")
                           {
                               mySqlCommand.Parameters.Add("@middlename", SqlDbType.VarChar, 50);
                               mySqlCommand.Parameters["@middlename"].Value = middlename;
                           }

                           if (lastname != "")
                           {
                               mySqlCommand.Parameters.Add("@lastname", SqlDbType.VarChar, 50);
                               mySqlCommand.Parameters["@lastname"].Value = lastname;
                           }

                           if (role != "")
                           {
                               mySqlCommand.Parameters.Add("@role", SqlDbType.VarChar, 10);
                               mySqlCommand.Parameters["@role"].Value = role;
                           }

                           mySqlCommand.ExecuteNonQuery();

                           break;

                       case "A": // Check for the existance of the userid and pin combination. We do this by issuing a count agaist the where.

                           sqlcommand = "select count(*) from e_customers where customerid=@customerid and pin=@pin and fi=@fi";
                           mySqlCommand.CommandText = sqlcommand;
                           // build 
                           mySqlCommand.Parameters.Add("@fi", SqlDbType.VarChar, 10);
                           mySqlCommand.Parameters.Add("@customerid", SqlDbType.VarChar, 50);
                           mySqlCommand.Parameters.Add("@pin", SqlDbType.VarChar, 128);
                          
                           //assign data
                           mySqlCommand.Parameters["@fi"].Value = fi;
                           mySqlCommand.Parameters["@customerid"].Value = customerid;
                           mySqlCommand.Parameters["@pin"].Value = hashcompare;

                           try
                           {
                               int iMyReturnValue = (int)mySqlCommand.ExecuteScalar();
                                                              
                               if (iMyReturnValue == 1)
                                   return "True";
                               if (iMyReturnValue == 0)
                                   return "False";
                               if (iMyReturnValue > 1)
                                   return "ToMany";
                           }
                           catch
                           {
                               return "False";
                           }
                           
                           break;
                   }
               }
               catch
               {
                   MessageBox.Show("error - e_customer failure", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               return "";
           }
     }
}
