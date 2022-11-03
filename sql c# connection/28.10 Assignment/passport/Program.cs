//Write a C# program to get a list of values from the user. 
//(Passport information: passport number, candidate name, passport expiry date, years of validity, applied through channel 
//(Normal, Priority),etc) for atleast 10 candidates.Create a table and upload
// this information to the table using a Stored Procedure.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace passport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string ConnectionString = "Data Source=INLPF379SHK\\MSSQLSERVER1;Initial Catalog=master;trusted_connection=true";
                SqlConnection sql = new SqlConnection(ConnectionString);
                sql.Open();

                int i = 0;
                while (i < 10)
                {
                    Console.WriteLine("Enter Candidate name:");
                    string Candidatename = Console.ReadLine();

                    Console.WriteLine("Enter the Expiry Date:");
                    string expirydate = Console.ReadLine();

                    Console.WriteLine("Enter the years of validity:");
                    int validity = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the Channel:");
                    string Channel = Console.ReadLine();

                    SqlCommand cmd = new SqlCommand("passport_det", sql);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = Candidatename;
                    cmd.Parameters.Add("@expydate", System.Data.SqlDbType.Date).Value = expirydate;
                    cmd.Parameters.Add("@validity", System.Data.SqlDbType.Int).Value = validity;
                    cmd.Parameters.Add("@channel", System.Data.SqlDbType.VarChar).Value = Channel;
                    cmd.ExecuteNonQuery();
                    i++;
                }

                Console.WriteLine("Data is uploaded successfully");
                sql.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Sql Exception");
                Console.WriteLine("Something Got Wrong with DataBase");
                Console.WriteLine(e.Message);
            }
        }
    }
}