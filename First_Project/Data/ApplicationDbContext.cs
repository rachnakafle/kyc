using First_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace First_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) : base(options)
        {
            
        } 

        public DbSet<Form> FormTable { get; set; }
    }
}
