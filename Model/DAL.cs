using System.Data;
using System.Data.SqlClient;

namespace DemoWebApp.Model
{
    public class DAL
    {
        public List<Users> GetUsers(IConfiguration configuration)
        {
            List<Users> listusers = new List<Users>();
            using (SqlConnection con = new SqlConnection(configuration.GetConnectionString("DBCS").ToString()))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TblUsers", con);
				DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Users users = new Users();
                        users.Id = Convert.ToString(dt.Rows[i]["Id"]);
                        users.FirstName = Convert.ToString(dt.Rows[i]["FirstName"]);  
                        users.LastName = Convert.ToString(dt.Rows[i]["LastName"]);
                        
                        
                    }
                }
            }
            return listusers;
        }
    }
}
