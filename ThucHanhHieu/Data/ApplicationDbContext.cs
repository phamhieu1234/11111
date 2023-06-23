using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ThucHanhHieu.Models;
namespace ThucHanhHieu.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
         public DbSet<ThucHanhHieu.Models.Student> Students { get; set; } = default!;
        
    }
}
