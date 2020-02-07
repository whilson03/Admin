using Admin.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Admin.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Member> Members { get; set; }

        public DbSet<Policy> Policies { get; set; }

        public DbSet<StaffUserReg> StaffUserRegs { get; set; }

       


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder builder)
        {
          

            // seeding the database
            var roles = new List<IdentityRole>()
            {
                new IdentityRole{Name="User", NormalizedName="USER" },
                 new IdentityRole{Name="Staff", NormalizedName="STAFF" }

            };


            // populate the database i.e identity role table :: database seeding
            builder.Entity<IdentityRole>().HasData(roles);

            base.OnModelCreating(builder);
        }
    }
}
