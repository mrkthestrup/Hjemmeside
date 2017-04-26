using Microsoft.EntityFrameworkCore;

namespace hjemmeside2.Models
{

public class MyDbContext : DbContext 
    {
    
        public DbSet<Booking> Bookings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite("Filename=./mydb.db");
        }

    }
}