using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using static Library_Management_System.Pages.MainPageModel;
using static Library_Management_System.Pages.IndexModel;
using static Library_Management_System.Pages.RegisterModel;


namespace Library_Management_System.Pages
{
    public class borrowModel : PageModel
    {
        public List<books> book = new List<books>();
         public List<logindetails> list = new List<logindetails>();
        public books borrow = new books();
        public logindetails l = new logindetails();
        public Register r = new Register();
        public string success_msg = "";
        public string error_msg = "";
        public void OnGet()
        {

            try
            {
                borrow.book_id = Convert.ToInt32(Request.Query["id"]);

                string ConnectionString = "Data Source=INLPF379SHK\\MSSQLSERVER1;Initial Catalog=project;trusted_connection=true";
                SqlConnection sqlCon = new SqlConnection(ConnectionString);
                sqlCon.Open();
                string query = "select book_id,book_name,rent_price from books where book_id=@id";
                

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = borrow.book_id;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    borrow.book_id = reader.GetInt32(0);
                    borrow.book_name = reader.GetString(1);
                    borrow.rent = reader.GetDecimal(2);


                    book.Add(borrow);

                }
                book.ForEach(x => Console.WriteLine(x.book_id + " " + x.book_name + " " + x.rent));
                sqlCon.Close();

              
                SqlConnection sqlCon1 = new SqlConnection(ConnectionString);
                sqlCon1.Open();
                borrow.email_id = Request.Query["emailid"];
                Console.WriteLine(borrow.email_id);
                string query1 = "select name,email_id from logindetails where email_id=@email_id";


                SqlCommand cmd1 = new SqlCommand(query1, sqlCon1);
                cmd1.Parameters.Add("@email_id", System.Data.SqlDbType.VarChar).Value = borrow.email_id;

                SqlDataReader reader1 = cmd1.ExecuteReader();

                while (reader1.Read())
                {
                    
                    borrow.name = reader1.GetString(0);
                    borrow.email_id = reader1.GetString(1);

                    book.Add(borrow);
             
                }

                Console.WriteLine("Check Station");
                book.ForEach(x => Console.WriteLine(x.name + " " + x.email_id));
                sqlCon1.Close();

                SqlConnection sqlCon2 = new SqlConnection(ConnectionString);
                sqlCon2.Open();
                SqlCommand cmd2 = new SqlCommand("quantityupdate", sqlCon2);
                Console.WriteLine("Done1"+borrow.book_name);
                cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                cmd2.Parameters.Add("@bookname", System.Data.SqlDbType.NVarChar).Value = borrow.book_name;
                cmd2.ExecuteNonQuery();
                Console.WriteLine("Done");
                sqlCon2.Close();
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
                borrow.book_id = Convert.ToInt32(Request.Query["id"]);
                borrow.email_id = Request.Query["emailid"];
   

                string ConnectionString = "Data Source=INLPF379SHK\\MSSQLSERVER1;Initial Catalog=project;trusted_connection=true";
                SqlConnection sqlCon = new SqlConnection(ConnectionString);

                borrow.book_name = Request.Form["book_name"];
                borrow.rent = Convert.ToDecimal(Request.Form["rentprice"]);
                borrow.name=Request.Form["name"];    
                Console.WriteLine("Check");
                Console.WriteLine(borrow.book_id);
                Console.WriteLine(borrow.book_name);
                Console.WriteLine(borrow.rent);
                Console.WriteLine(borrow.name);
                Console.WriteLine(borrow.email_id);


                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("borrowdetails", sqlCon);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@book_id", System.Data.SqlDbType.Int).Value = borrow.book_id;
                cmd.Parameters.Add("@book_name", System.Data.SqlDbType.NVarChar).Value = borrow.book_name;
                cmd.Parameters.Add("@rent_price", System.Data.SqlDbType.Decimal).Value = borrow.rent;
                cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = borrow.name;
                cmd.Parameters.Add("@email_id", System.Data.SqlDbType.NVarChar).Value = borrow.email_id;
                cmd.Parameters.Add("@borrow_date_from", System.Data.SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@borrow_date_to", System.Data.SqlDbType.DateTime).Value = DateTime.Now.AddDays(21);
                cmd.Parameters.Add("@returnstatus", System.Data.SqlDbType.VarChar).Value = '-';
                cmd.ExecuteNonQuery();

                sqlCon.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Sql related problem");
                error_msg = "Error! Enter your Name and EmailId correctly!";
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("C# related problem");
                error_msg = "Error! Enter your Name and EmailId correctly!";
                return;
            }
            success_msg = "You have Successfully borrowed the book " + borrow.book_name + " for the price of Rs. " + borrow.rent;
            
            
        }
    }
}
