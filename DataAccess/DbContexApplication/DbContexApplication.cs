using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.DbContext
{
    public class DbContexApplication
    {
        public IDbConnection CreateConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            return new SqlConnection(connectionString);
        }
    }
}
