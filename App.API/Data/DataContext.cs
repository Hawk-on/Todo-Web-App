using App.API.Models;
using Microsoft.EntityFrameworkCore;

namespace App.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<User> Users{ get; set; }

        public DbSet<TodoPoint> TodoPoints{ get; set; }
    }
}