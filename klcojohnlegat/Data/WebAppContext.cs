using klcojohnlegat.Models;
using Microsoft.EntityFrameworkCore;

namespace klcojohnlegat.Data
{
    public class WebAppContext : DbContext
        
    {
        public DbSet<UserModel> Users { get; set; }

        public WebAppContext(DbContextOptions<WebAppContext> options) : base(options) 
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().HasData(
                new UserModel()
                {
                    Name = "Admin",
                    Password = "123",
                    Role = Models.Enum.UserRole.Admin
                }
                
                
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
