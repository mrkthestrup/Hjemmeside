using hjemmeside2.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace hjemmeside2.Models
{

public class MyDbContext : DbContext 
    {
    
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BlogPost> Blogs {get; set;}

        public DbSet<TodoItem> todoitems { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite("Filename=./mydb.db");
        }

    }
}