using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Baithuchanh.Models;
namespace Baithuchanh.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
         public DbSet<Baithuchanh.Models.Student> Students { get; set; } = default!;
        
    }
}
