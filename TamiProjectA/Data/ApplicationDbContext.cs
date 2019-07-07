using System;
using Microsoft.EntityFrameworkCore;
using TamiProjectA.Models;

namespace TamiProjectA.Data
    
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<line_item> line_items { get; set; }
    }
}
