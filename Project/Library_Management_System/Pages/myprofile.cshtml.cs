using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Library_Management_System.Pages.IndexModel;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Library_Management_System.Pages
{
    public class myprofileModel : PageModel
    {
        public List<logindetails> list = new List<logindetails>();
        public logindetails logindetails = new logindetails();
        public void OnGet()
        {
            try
            {

                string ConnectionString = "Data Source=INLPF379SHK\\MSSQLSERVER1;Initial Catalog=project;trusted_connection=true";
                SqlConnection sqlCon = new SqlConnection(ConnectionString);

                sqlCon.Open();

                logindetails.email_id = Request.Query["emailid"];
                Console.WriteLine(logindetails.email_id);


                string query = "select * from logindetails where email_id = @email_id";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.Add("@email_id", System.Data.SqlDbType.VarChar).Value = logindetails.email_id;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    logindetails l1 = new logindetails();
                    l1.id_no = reader.GetInt32(0);
                    l1.name = reader.GetString(1);
                    l1.phone_number = reader.GetInt64(2);
                    l1.age = reader.GetInt32(3);
                    l1.email_id = reader.GetString(4);
                    l1.password = reader.GetString(5);

                    list.Add(l1);
                }

                //book.ForEach(x => Console.WriteLine(x.book_id + " " + x.author_name + " " + x.book_name + " " + x.genre + " " + x.release_date + " " + x.quantity + " " + x.rent));

                sqlCon.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Sql related problem");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("C# related problem");
                return;
            }
        }

    }


}

