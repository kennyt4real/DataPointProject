using DataPointProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataPointProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            PopulateUserRole(builder);
        }
        static void PopulateUserRole(ModelBuilder builder)
        {
            // any guid
            string ADMIN_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e513";
           
            // any guid, but nothing is against to use the same one
            string ROLE_ID = ADMIN_ID;
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = ROLE_ID, Name = "Admin", NormalizedName = "Admin" });


            var hasher = new PasswordHasher<ApplicationUser>();

            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = ADMIN_ID,
                UserName = "Admin@test.com",
                Email = "Admin@test.com",
                NormalizedUserName = "ADMIN@TEST.COM",
                NormalizedEmail = "ADMIN@TEST.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admintest@12345"),
                SecurityStamp = string.Empty
            });

           
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });

           
        }

        public DbSet<Member> Members { get; set; }
    }
}
