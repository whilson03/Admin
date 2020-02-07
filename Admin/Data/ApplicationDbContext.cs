using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Admin.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Member> Members { get; set; }

        public DbSet<BankDetail> BankDetails { get; set; }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Member>()
           .HasOne(b => b.BankDetail)
           .WithOne(i => i.Member)
           .HasForeignKey<BankDetail>(b => b.MemberId);

            builder.Entity<Member>()
           .HasOne(b => b.PaymentDetail)
           .WithOne(i => i.Member)
           .HasForeignKey<PaymentDetail>(b => b.MemberId);

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
