using Cz.Project.Domain.Business;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace Cz.Project.SQLContext
{
    public class SQLCreation
    {
        public void Create()
        {
            SqlConnection mycon = new SqlConnection("Server=./;initial catalog=Cz.Project;Integrated security=SSPI;database=master");

            try
            {
                string query = "CREATE DATABASE [Cz.Project]";

                SqlCommand mycommand1 = new SqlCommand(query, mycon);
                mycommand1.Connection.Open();
                mycommand1.ExecuteNonQuery();
                mycon.Close();


                using (var sr = new StreamReader("./CzSchema.sql"))
                {
                    query = sr.ReadToEnd();
                }

                SqlCommand mycommand2 = new SqlCommand(query, mycon);
                mycommand2.Connection.Open();
                mycommand2.ExecuteNonQuery();
                mycon.Close();

                using (var sr = new StreamReader("./CzData.sql"))
                {
                    query = sr.ReadToEnd();
                }

                SqlCommand mycommand3 = new SqlCommand(query, mycon);
                mycommand3.Connection.Open();
                mycommand3.ExecuteNonQuery();
                mycon.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (mycon.State == ConnectionState.Open)
                {
                    mycon.Close();
                }
            }
        }
    }
}
