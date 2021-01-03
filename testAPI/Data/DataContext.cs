using Microsoft.EntityFrameworkCore;
using testAPI.Entities;

namespace testAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext( DbContextOptions options) : base(options)
        {
        }
            public DbSet<AppUser> Users { get; set; }
    }
}