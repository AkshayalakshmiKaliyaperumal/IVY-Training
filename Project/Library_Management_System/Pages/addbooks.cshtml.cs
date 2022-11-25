using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Library_Management_System.Pages
{
    public class addbooksModel : PageModel
    {
        public void OnGet()
        {
        }

        public class booksadd
        {
            public int quantity;
            public string bookname, authorname, genre;
            public DateTime releasedate;
            public decimal rentprice;

        }

        booksadd add = new booksadd();
        public string error_msg = "";
        public string success_msg = "";
        public void OnPost()
        {
            try
            {
                string ConnectionString = "Data Source=INLPF379SHK\\MSSQLSERVER1;Initial Catalog=project;trusted_connection=true";
                SqlConnection sqlCon = new SqlConnection(ConnectionString);


                add.bookname = Request.Form["bookname"];
                add.authorname = Request.Form["authorname"];
                add.genre = Request.Form["genre"];
                add.releasedate = Convert.ToDateTime(Request.Form["releasedate"]);
                add.quantity = Convert.ToInt32(Request.Form["quantity"]);
                add.rentprice = Convert.ToDecimal(Request.Form["price"]);



                sqlCon.Open();



                SqlCommand cmd = new SqlCommand("addbooks", sqlCon);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@bookname", System.Data.SqlDbType.NVarChar).Value = add.bookname;
                cmd.Parameters.Add("@authorname", System.Data.SqlDbType.NVarChar).Value = add.authorname;
                cmd.Parameters.Add("@genre", System.Data.SqlDbType.NVarChar).Value = add.genre;
                cmd.Parameters.Add("@releasedate", System.Data.SqlDbType.DateTime).Value = add.releasedate;
                cmd.Parameters.Add("@quantity", System.Data.SqlDbType.Int).Value = add.quantity;
                cmd.Parameters.Add("@rentprice", System.Data.SqlDbType.Decimal).Value = add.rentprice;


                cmd.ExecuteNonQuery();
                sqlCon.Close();
                success_msg = "Added Sucessfully!";

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Sql related problem: ");
                Console.WriteLine(ex.Message);
                error_msg = "Error! Enter all the values correctly";
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("C# related problem: ");
                Console.WriteLine(ex.Message);
                error_msg = "Error! Enter all the values correctly";
                return;
            }
        }

    }
}
