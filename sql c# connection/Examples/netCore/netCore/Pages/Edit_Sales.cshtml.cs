using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace netCore.Pages
{
    public class Edit_SalesModel : PageModel
    {
        public List<Sales_info> list_name = new List<Sales_info>();
        public Sales_info update = new Sales_info();
        public string success_msg = "";
        public string error_msg = "";
        public void OnGet()
        {

            try
            {
                 update.s_id = Convert.ToInt32(Request.Query["id"]);

                //Console.Write(update.s_id);
               // string s_id = Request.Query["id"];
                //Console.Write("s_id="+s_id);

                string ConnectionString = "Data Source=INLPF379SHK\\MSSQLSERVER1;Initial Catalog=master;trusted_connection=true";
                // string ConnectionString1 = _configuration.GetConnectionString("DefaultConnection");
                ;
                SqlConnection sqlCon = new SqlConnection(ConnectionString);
                sqlCon.Open();
                string query = "select s_name,amount,city,email_id from sales_detail where s_id=@id";


                SqlCommand cmd = new SqlCommand(query, sqlCon);
                
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = update.s_id;
                // cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    
                    update.s_name = reader.GetString(0);
                    update.amount = reader.GetInt64(1);
                    update.city = reader.GetString(2);
                    update.email_id = reader.GetString(3);

                    list_name.Add(update);


                }
                list_name.ForEach(x => Console.WriteLine(x.s_id + " " + x.s_name + " " + x.amount + " " + x.city + " " + x.email_id));

                //Console.Log(list_name);
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
                string ConnectionString = "Data Source=INLPF379SHK\\MSSQLSERVER1;Initial Catalog=master;trusted_connection=true";
                SqlConnection sqlCon = new SqlConnection(ConnectionString);

                Console.WriteLine("OnPost");

                update.s_name = Request.Form["name"];
                update.amount = Convert.ToInt64(Request.Form["amount"]);
                update.city = Request.Form["city"];
                update.email_id = Request.Form["email_id"];



                sqlCon.Open();

                SqlCommand cmd = new SqlCommand("update_sales", sqlCon);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@p_s_id", System.Data.SqlDbType.Int).Value = update.s_id;

                cmd.Parameters.Add("@p_s_name", System.Data.SqlDbType.VarChar).Value = update.s_name;
                cmd.Parameters.Add("@p_s_amount", System.Data.SqlDbType.BigInt).Value = update.amount;
                cmd.Parameters.Add("@p_city", System.Data.SqlDbType.VarChar).Value = update.city;
                

                cmd.ExecuteNonQuery();



                sqlCon.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Sql related problem");
                error_msg = ex.Message;
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("C# related problem");
                error_msg = ex.Message;
                return;
            }
            update.s_name = "";
            update.amount = 0;
            update.city = "";
            update.email_id = "";

            success_msg = "Succefully added";
            error_msg = "Error -sql problem";

            //            Response.Redirect("/sales");

        }

    }

   
}
