using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using Dapper.Data.Model;

namespace Dapper.Data
{
    public class DataUtils
    {
        private static readonly string connectionString= "Data Source=.;Initial Catalog=VideoDB;user id=sa;password=asdf.123;";
        public IEnumerable<User> Execute()
        {
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
               var users= conn.Query<User>("select * from [Users]");
             
                return users;
            }
        }
    }
}
