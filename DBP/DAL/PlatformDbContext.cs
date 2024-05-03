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

        public DbSet<Advertisement> Advertisement { get; set; }
        public DbSet<BillingInformation> BillingInformation { get; set; }
        public DbSet<CareerCenter> CareerCenter { get; set; }
        public DbSet<Certificate> Certificate { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyOffer> CompanyOffer { get; set; }
        public DbSet<Consultation> Consultation { get; set; }
        public DbSet<ContactInfo> ContactInfo { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseSources> CourseSources { get; set; }
        public DbSet<Entity> Entity { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<InformationSource> InformationSource { get; set; }
        public DbSet<Lecture> Lecture { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }

    }
}