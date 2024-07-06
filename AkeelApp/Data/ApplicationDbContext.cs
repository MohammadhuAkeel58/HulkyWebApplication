using AkeelApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AkeelApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) 
        {
            
        }
        public DbSet<Category> categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Akeel", DisplayOrder = 1 },
                  new Category { Id = 2, Name = "Akeel", DisplayOrder = 2 },
                    new Category { Id = 3, Name = "Akeel", DisplayOrder = 3 });
        }
    }
}
