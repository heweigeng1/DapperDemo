using LibraryCreateDatabase.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LibraryCreateDatabase
{
  public  class EFUtils
    {
        public void Add(User user)
        {
            using (var db=new InitContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
        public void AddRange(List<User> users)
        {
            using (var db=new InitContext())
            {
                db.Users.AddRange(users);
                db.SaveChanges();
            }
        }
        public List<AreaDto> LinqSelectArea(string code)
        {
            using (var db=new InitContext())
            {
                return (from a1 in db.Areas
                        join a2 in db.Areas on a1.AreaCode equals a2.ParentAreaCode
                        where a1.AreaCode == code
                        select new AreaDto
                        {
                            Name=a1.Name,
                            pName=a2.Name
                        }).ToList();
            }
        }
    }
}
