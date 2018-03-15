using LibraryCreateDatabase;
using LibraryCreateDatabase.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace 洛延
{
    public class InitData
    {
        public User GetUser()
        {
            return new User
            {
                Id = Guid.NewGuid(),
                UserName = "tom",
                PhoneNum = ""
            };
        }

        public List<User> GetUsers(int num)
        {
            return Enumerable.Range(0, num).Select(i => GetUser()).ToList();
        }
    }
}
