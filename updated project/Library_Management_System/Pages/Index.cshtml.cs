using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;


namespace Library_Management_System.Pages
{
    
    public class IndexModel : PageModel
    {
        
        public string sucessemail = "";
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {


        }

        public class logindetails
        {
            public int id_no, age;
            public string name, email_id, password;
            public long phone_number;
            
        }

        public logindetails l = new logindetails();
        public string error_msg = "";
        

        protected void remember()
        {

        }
        public void OnPost()
        {
            try
            {
                string ConnectionString = "Data Source=INLPF379SHK\\MSSQLSERVER1;Initial Catalog=project;trusted_connection=true";
                SqlConnection sqlCon = new SqlConnection(ConnectionString);



                l.email_id = Request.Form["email"];
                string pass_word = Request.Form["password"];

                if (l.email_id == "akshaya@gmail.com" && pass_word == "Akshu@2222")
                {
                    Response.Redirect("/AdminPage");
                }
                else
                {
                    sqlCon.Open();

                    SqlCommand cmd = new SqlCommand("Login_details", sqlCon);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@email_id", System.Data.SqlDbType.NVarChar).Value = l.email_id;

                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();

                    reader.Read();
                    l.password = reader.GetString(0);

                    sqlCon.Close();

                    if (pass_word == l.password)
                    {
                        Console.WriteLine("Login Success");
                        Response.Redirect("/MainPage?emailid="+l.email_id);
                    }
                    else
                    {

                        ViewData["LoginFlag"] = "Invalid Email id or Password!";
                        Console.WriteLine("Login Failed");
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Sql related problem: ");
                Console.WriteLine(ex.Message);
                error_msg = "Invalid Email ID or Password";
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("C# related problem: ");
                Console.WriteLine(ex.Message);
                error_msg = "Invalid Email ID or Password";
                return;
            }
        }
       
    }
}