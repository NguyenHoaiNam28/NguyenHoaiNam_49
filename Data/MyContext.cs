#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenHoaiNam.Models;

    public class MyContext : DbContext
    {
        public MyContext (DbContextOptions<MyContext> options)
            : base(options)
        {
        }

        public DbSet<NguyenHoaiNam.Models.Category> Category { get; set; }

        public DbSet<NguyenHoaiNam.Models.News> News { get; set; }

        public DbSet<NguyenHoaiNam.Models.Comment> Comment { get; set; }
    }
