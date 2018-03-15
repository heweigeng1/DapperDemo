using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCreateDatabase.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string PhoneNum { get; set; }
    }
}
