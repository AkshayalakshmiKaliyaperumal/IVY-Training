using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace netCore.Pages
{
    public class salesModel : PageModel
    {
        
        public List<Sales_info> list_name = new List<Sales_info>();
       
        public void OnGet()
        {
            try
            {

                string ConnectionString = "Data Source=INLPF379SHK\\MSSQLSERVER1;Initial Catalog=master;trusted_connection=true";
                // string ConnectionString1 = _configuration.GetConnectionString("DefaultConnection");
                ;
                SqlConnection sqlCon = new SqlConnection(ConnectionString);
                sqlCon.Open();
                string query = "select * from sales_detail";

                SqlCommand cmd = new SqlCommand(query, sqlCon);
               // cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Sales_info info = new Sales_info();
                    info.s_id = reader.GetInt32(0);
                    info.s_name = reader.GetString(1);
                    info.amount = reader.GetInt64(2);
                    info.city = reader.GetString(3);
                    info.phone_no = reader.GetInt64(4);

                    list_name.Add(info);


                }
                list_name.ForEach(x=> Console.WriteLine(x.s_id+" "+x.s_name+" "+x.amount+" "+x.city+" "+x.phone_no));
               
                //Console.Log(list_name);
                sqlCon.Close();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Sql related problem");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("C# related problem");
            }
        }

    }

    public class Sales_info
    {
        public int s_id;
      public string s_name,city;
       public long amount,phone_no;

        
    }


}
