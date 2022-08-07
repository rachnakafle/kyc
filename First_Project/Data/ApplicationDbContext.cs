using First_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace First_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) : base(options)
        {
            
        } 

        public DbSet<Form> FormTable { get; set; }
        public DbSet<ImageModel> Images { get; set; }

        //public DbSet<Product> Product { get; set; }
        //public DbSet<ExtraDetails> extra_details { get; set; }
        //public DbSet<Form> province { get; set; }

        //internal List<Form> province()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
