using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CoffeeShop.Models;

namespace CoffeeShop.Dal
{
    public class SignUpDal : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("User");
        }
        public DbSet<User> Users { get; set; }

    }

}