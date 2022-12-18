using AviatorWebSite.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AviatorWebSite.Data
{
    public class AccessDbContext : DbContext
    {
        public AccessDbContext(DbContextOptions<AccessDbContext> options) : base(options)
        {

        }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Aircraft> Fleet { get; set; }
    }
}
