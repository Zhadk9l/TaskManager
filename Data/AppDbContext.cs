using Microsoft.EntityFrameworkCore;
using TaskManager.Models;
namespace TaskManager.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Project> projects { get; set; }
        public DbSet<TaskItem> taskItems { get; set; }
        public DbSet<User> users { get; set;}
    }
}
