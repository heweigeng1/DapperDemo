using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using LibraryCreateDatabase.Model;

namespace Dapper.Data
{
    public class DataUtils
    {
        private static readonly string connectionString = "Data Source=.;Initial Catalog=EFCoreCode;user id=sa;password=asdf.123;";
        public IEnumerable<User> Execute()
        {
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                var users = conn.Query<User>("select * from [Users]");
                return users;
            }
        }
        public void Add(User user)
        {
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                var result = conn.Execute("insert into Users  values(@Id,@UserName,@PhoneNum)", user);
            }
        }
        public void AddRange(List<User> users)
        {
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                var result = conn.Execute("insert into Users  values(@Id,@UserName,@PhoneNum)", users);
            }
        }


        public void InitArea()
        {
            try
            {
                string sql = File.ReadAllText(@"F:\github\DapperDemo\洛延\TestData\address.sql");
                using (IDbConnection conn = new SqlConnection(connectionString))
                {
                    var result = conn.Execute(sql);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<AreaDto> SelectAreaByCode(string code)
        {
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                var result = conn.Query<AreaDto>("select a1.Name,a2.Name as pName from Areas as a1 left join Areas as a2 on a1.AreaCode=a2.ParentAreaCode where a1.AreaCode=@code;", new { code});
                return result.AsList();
            }
        }

    }
  
}
