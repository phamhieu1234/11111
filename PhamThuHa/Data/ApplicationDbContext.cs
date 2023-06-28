using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhamThuHa.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PhamThuHa.Models.Student> Student { get; set; } = default!;

        public DbSet<PhamThuHa.Models.KhachSan> KhachSan { get; set; } = default!;
    }
