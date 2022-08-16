using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MobilityRentApp_Backend.Model.Entities;

namespace MobilityRentApp_Backend.Data
{
    public class ApplicationDbContext : 
        DbContext
        //IdentityDbContext
        //IdentityDbContext<Microsoft.AspNetCore.Identity.IdentityUser, Microsoft.AspNetCore.Identity.IdentityRole, string>
    {
        //public ApplicationDbContext():base() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<MobilityKind> MobilityKinds { get; set; }
        public DbSet<Mobility> Mobilities { get; set; }
        public DbSet<RentEnrollment> RentEnrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mobility>()
                .HasOne(m => m.RentEnrollment)
                .WithOne(r => r.Mobility)
                .IsRequired(false);

            
        }

    }
}
