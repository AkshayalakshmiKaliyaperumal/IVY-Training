//Write a C# program and display Movie information to customers, according to the genre they choose: 
//If they say, "horror" , atleast 5 horror movies must be displayed; 
//similarly if they choose 'kids' , animation and kids friendly movies should be displayed.
//Use UDF and display information on screen.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;
namespace movies
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

                Console.WriteLine("Enter the Movie genre : ");
                string genre = Console.ReadLine();
                Console.WriteLine();

                SqlCommand cmd = new SqlCommand("select * from dbo.movie_info(@genre)", sql);
                cmd.Parameters.Add("@genre", System.Data.SqlDbType.VarChar).Value = genre;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(0));
                }
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