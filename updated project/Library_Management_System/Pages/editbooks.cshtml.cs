using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;
using static Library_Management_System.Pages.AdminPageModel;

namespace Library_Management_System.Pages
{
    public class editbooksModel : PageModel
    {

        public List<books> book = new List<books>();
        public books update = new books();
        public string success_msg = "";
        public string error_msg = "";
        public void OnGet()
        {

            try
            {
                update.book_id = Convert.ToInt32(Request.Query["id"]);

                string ConnectionString = "Data Source=INLPF379SHK\\MSSQLSERVER1;Initial Catalog=project;trusted_connection=true";
                SqlConnection sqlCon = new SqlConnection(ConnectionString);
                sqlCon.Open();
                string query = "select * from books where book_id=@id";


                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = update.book_id;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    update.book_id = reader.GetInt32(0);
                    update.book_name = reader.GetString(1);
                    update.author_name = reader.GetString(2);
                    update.genre = reader.GetString(3);
                    update.release_date = Convert.ToDateTime(reader.GetDateTime(4));
                    update.quantity = reader.GetInt32(5);
                    update.rent = reader.GetDecimal(6);
                    

                    book.Add(update);


                }
                book.ForEach(x => Console.WriteLine(x.book_id+" "+x.author_name + " " + x.book_name + " " + x.genre + " " + x.release_date + " " + x.quantity + " " + x.rent));

                sqlCon.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Sql related problem");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("C# related problem");
            }
        }


        public void OnPost()
        {
            try
            {
                update.book_id = Convert.ToInt32(Request.Query["id"]);

                string ConnectionString = "Data Source=INLPF379SHK\\MSSQLSERVER1;Initial Catalog=project;trusted_connection=true";
                SqlConnection sqlCon = new SqlConnection(ConnectionString);

                update.book_name= Request.Form["bookname"];
                update.author_name= Request.Form["authorname"];
                update.genre = Request.Form["genre"];
                update.release_date = Convert.ToDateTime(Request.Form["releasedate"]);
                update.quantity = Convert.ToInt32( Request.Form["quantity"]);
                update.rent = Convert.ToDecimal(Request.Form["rentprice"]);


                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("update_books", sqlCon);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@bookid", System.Data.SqlDbType.Int).Value = update.book_id;
                cmd.Parameters.Add("@quantity", System.Data.SqlDbType.Int).Value = update.quantity;
                cmd.Parameters.Add("@rentprice", System.Data.SqlDbType.Decimal).Value = update.rent;
                cmd.ExecuteNonQuery();

                sqlCon.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Sql related problem");
                error_msg = "Error! Enter all the values correctly";
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("C# related problem");
                error_msg = "Error! Enter all the values correctly";
                return;
            }
            update.quantity = 0;
            update.rent = 0;
            update.author_name = "";
            update.book_name = "";
            update.genre = "";
      

            success_msg = "Succefully Added";

        }

    }
}

