//Create a table where there are the following fields: event id, events(anniversary, conference, 
//seminar, party,etc), event date, organizer, location, total cost, etc Create a Stored Procedure to fetch
//all the events happening in the month of (get the input from the user).Display the results on screen.
//Example: If the user inputs September, display all the events that happened in September.
//Create a UDF to calculate the events that cost the maximum money.
//Create a Stored Procedure and display on screen, the events that happened in a particular location.
//(Get the location as input from the user)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;
namespace Event
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

                Console.WriteLine("Enter the month of event: ");
                string month = Console.ReadLine();
                Console.WriteLine();

                SqlCommand cmd = new SqlCommand("event_month", sql);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@month", System.Data.SqlDbType.NVarChar).Value = month;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader.GetInt32(0));
                    Console.WriteLine(reader.GetString(1));
                    Console.WriteLine(reader.GetString(2));
                    Console.WriteLine(reader.GetString(3));
                    Console.WriteLine(reader.GetString(4));
                    Console.WriteLine(reader.GetInt32(5));
                    Console.WriteLine();
                }
                reader.Close();
                Console.WriteLine("Enter the location of event: ");
                string location = Console.ReadLine();
                Console.WriteLine();

                SqlCommand cmd1 = new SqlCommand("event_location", sql);
                cmd1.CommandType = System.Data.CommandType.StoredProcedure;
                cmd1.Parameters.Add("@location", System.Data.SqlDbType.NVarChar).Value = location;
                SqlDataReader reader1 = cmd1.ExecuteReader();

                while (reader1.Read())
                {
                    Console.WriteLine(reader1.GetInt32(0));
                    Console.WriteLine(reader1.GetString(1));
                    Console.WriteLine(reader1.GetString(2));
                    Console.WriteLine(reader1.GetString(3));
                    Console.WriteLine(reader1.GetString(4));
                    Console.WriteLine(reader1.GetInt32(5));
                    Console.WriteLine();
                }
                reader1.Close();

                SqlCommand cmd2 = new SqlCommand("select * from dbo.event_money()", sql);
                SqlDataReader reader2 = cmd2.ExecuteReader();

                while (reader2.Read())
                {
                    Console.WriteLine(reader2.GetInt32(0));
                    Console.WriteLine();
                }
                reader2.Close();

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