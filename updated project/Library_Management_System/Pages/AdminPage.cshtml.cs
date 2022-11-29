using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Library_Management_System.Pages
{
    public class AdminPageModel : PageModel
    {
        public void OnGet()
        {
            try
            {

                string ConnectionString = "Data Source=INLPF379SHK\\MSSQLSERVER1;Initial Catalog=project;trusted_connection=true";
                SqlConnection sqlCon = new SqlConnection(ConnectionString);

                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("bookslist", sqlCon);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    books b1 = new books();
                    b1.book_id = reader.GetInt32(0);
                    b1.book_name = reader.GetString(1);
                    b1.author_name = reader.GetString(2);
                    b1.genre = reader.GetString(3);
                    b1.release_date = reader.GetDateTime(4);
                    b1.quantity = reader.GetInt32(5);
                    b1.rent = reader.GetDecimal(6);
                    book.Add(b1);

                }

               // book.ForEach(x => Console.WriteLine(x.book_id + " " + x.author_name + " " + x.book_name + " " + x.genre + " " + x.release_date + " " + x.quantity + " " + x.rent));

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
        public class books
        {
            public int book_id, quantity,borrow_id;
            public string book_name, author_name, genre,name,email_id,returnstatus;
            public DateTime release_date;
            public DateTime borrow_date_from;
            public DateTime borrow_date_to;
            public decimal rent;

        }

        public List<books> book = new List<books>();
        books b = new books();
        public string error_msg = "";
        public void OnPost()
        {
            try
            {
                string ConnectionString = "Data Source=INLPF379SHK\\MSSQLSERVER1;Initial Catalog=project;trusted_connection=true";
                SqlConnection sqlCon = new SqlConnection(ConnectionString);

                b.genre = Request.Form["search"];

                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("search", sqlCon);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@search", System.Data.SqlDbType.NVarChar).Value = b.genre;

                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    books b1 = new books();
                    b1.book_id = reader.GetInt32(0);
                    b1.book_name = reader.GetString(1);
                    b1.author_name = reader.GetString(2);
                    b1.genre = reader.GetString(3);
                    b1.release_date = reader.GetDateTime(4);
                    b1.quantity = reader.GetInt32(5);
                    b1.rent = reader.GetDecimal(6);
                    book.Add(b1);

                }

               // book.ForEach(x => Console.WriteLine(x.book_id + " " + x.author_name + " " + x.book_name + " " + x.genre + " " + x.release_date + " " + x.quantity + " " + x.rent));

                sqlCon.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Sql related problem: ");
                Console.WriteLine(ex.Message);
                error_msg = "This Genre is available!";
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("C# related problem: ");
                Console.WriteLine(ex.Message);
                error_msg = "This Genre is available!";
                return;
            }
        }
    }
}
