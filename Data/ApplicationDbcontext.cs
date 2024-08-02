using list_item.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace list_item.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<tasklist> lists { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json",true,reloadOnChange:true)
                .Build();
               var connection= builder.GetConnectionString("Defaultconnection");

            optionsBuilder.UseSqlServer(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            modelBuilder.Entity<tasklist>().HasData(
                new tasklist { Id = 1, Title = "Task 1", Description = "Description 1", Deadline = DateTime.Now.AddDays(1) },
                new tasklist { Id = 2, Title = "Task 2", Description = "Description 2", Deadline = DateTime.Now.AddDays(2) },
                new tasklist { Id = 3, Title = "Task 3", Description = "Description 3", Deadline = DateTime.Now.AddDays(3) }
            );
        }
    }
}
