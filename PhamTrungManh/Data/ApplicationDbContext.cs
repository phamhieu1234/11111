using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhamTrungManh.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PhamTrungManh.Models.Student> Student { get; set; } = default!;

        public DbSet<PhamTrungManh.Models.LopHoc> LopHoc { get; set; } = default!;
    }
