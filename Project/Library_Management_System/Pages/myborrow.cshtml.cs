using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Library_Management_System.Pages.IndexModel;
using System.Data.SqlClient;
using static Library_Management_System.Pages.MainPageModel;

namespace Library_Management_System.Pages
{
    public class myborrowModel : PageModel
    {
        public books borrow = new books();
        public List<books> book = new List<books>();
        public void OnGet()
        {
            try
            {

                string ConnectionString = "Data Source=INLPF379SHK\\MSSQLSERVER1;Initial Catalog=project;trusted_connection=true";
                SqlConnection sqlCon = new SqlConnection(ConnectionString);

                sqlCon.Open();
                borrow.email_id = Request.Query["emailid"];
                Console.WriteLine(borrow.email_id);

                string query = "select * from borrow_details where email_id = @email_id";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.Add("@email_id", System.Data.SqlDbType.VarChar).Value = borrow.email_id;

                SqlDataReader reader = cmd.ExecuteReader();
              
                while (reader.Read())
                {
                    books b1 = new books();

                    b1.borrow_id = reader.GetInt32(0);
                    b1.book_id = reader.GetInt32(1);
                    b1.book_name = reader.GetString(2);
                    b1.rent = reader.GetDecimal(3);
                    b1.name = reader.GetString(4);
                    b1.email_id = reader.GetString(5);
                    b1.borrow_date_from = reader.GetDateTime(6);
                    b1.borrow_date_to = reader.GetDateTime(7);
                    book.Add(b1);

                }

                book.ForEach(x => Console.WriteLine(x.book_id + " " + x.author_name + " " + x.book_name + " " + x.genre + " " + x.release_date + " " + x.quantity + " " + x.rent));

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
