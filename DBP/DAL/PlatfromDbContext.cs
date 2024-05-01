using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI;

namespace DAL
{
    public class PlatformDbContext : DbContext
    {
        public PlatformDbContext(DbContextOptions<PlatformDbContext> options)
            : base(options) { }

        public DbSet<Course> Course { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Lecture> Lecture { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Student> Student { get; set; }

    }
}