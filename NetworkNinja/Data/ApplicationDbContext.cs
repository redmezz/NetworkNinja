using Microsoft.EntityFrameworkCore;
using NetworkNinja.Models;

namespace NetworkNinja.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ForumModel> Forums { get; set; }
        public DbSet<SubForumModel> SubForums { get; set; }
        public DbSet<HardwareModel> Hardware { get; set; }
        public DbSet<SoftwareModel> Software { get; set; }
        public DbSet<PrinterModel> Printer { get; set; }
        public DbSet<PhoneModel> Phone { get; set; }
        public DbSet<AdministrationModel> Administration { get; set; }
        public DbSet<UserModel> Users { get; set; }
        
    }
}
