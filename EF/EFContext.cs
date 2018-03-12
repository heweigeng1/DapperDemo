using EF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF
{
    public class EFContext : DbContext
    {
        DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=VideoDB;user id=sa;password=asdf.123;");
        }

        public EFContext() : base()
        {
        }
    }
}
