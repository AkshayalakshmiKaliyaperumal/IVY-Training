using System.Data.SqlClient;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ConnectionString = "Data Source=INLPF379SHK\\MSSQLSERVER1;Initial Catalog=master;trusted_connection=true";
            SqlConnection sqlCon = new SqlConnection(ConnectionString);
            using System.Data.SqlClient;
        }
    }
}