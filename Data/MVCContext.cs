using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.Data
{
    public class MVCContext : DbContext
    {
        public MVCContext(DbContextOptions<MVCContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
    }
}
