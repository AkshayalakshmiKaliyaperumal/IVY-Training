using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Library_Management_System.Pages
{
    public class RegisterModel : PageModel
    {
        public void OnGet()
        {
        }

        public class Register
        {
            public int id_no, age;
            public string name, email_id, password;
            public long phone_number;

        }

        public Register r = new Register();
        public string error_msg = "";
        public string success_msg = "";
        public void OnPost()
        {
            try
            {
                string ConnectionString = "Data Source=INLPF379SHK\\MSSQLSERVER1;Initial Catalog=project;trusted_connection=true";
                SqlConnection sqlCon = new SqlConnection(ConnectionString);


                r.name = Request.Form["name"];
                r.phone_number = Convert.ToInt64(Request.Form["phonenumber"]);
                r.age = Convert.ToInt32(Request.Form["age"]);
                r.email_id = Request.Form["email"];
                r.password = Request.Form["password"];



                sqlCon.Open();



                SqlCommand cmd = new SqlCommand("Register", sqlCon);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = r.name;
                cmd.Parameters.Add("@phone_number", System.Data.SqlDbType.BigInt).Value = r.phone_number;
                cmd.Parameters.Add("@age", System.Data.SqlDbType.Int).Value = r.age;
                cmd.Parameters.Add("@password", System.Data.SqlDbType.NVarChar).Value = r.password;
                cmd.Parameters.Add("@email_id", System.Data.SqlDbType.NVarChar).Value = r.email_id;

                cmd.ExecuteNonQuery();
                sqlCon.Close();
                success_msg = "Registered Sucessfully!";

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
