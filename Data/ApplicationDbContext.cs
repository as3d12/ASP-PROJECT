using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Eagle.Models;
using System.Security.Principal;
using Microsoft.AspNetCore.Identity;

namespace Eagle.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Eagle.Models.Section> tblSection { get; set; }
        public DbSet<Eagle.Models.Trip> tblTrip { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var Admin = new IdentityRole("Admin");
            Admin.NormalizedName = "Admin";

            builder.Entity<IdentityRole>().HasData(Admin);

            builder.Entity<Section>().HasData(
                new Section { SectionId = 1, Name = "Air Flight" },
                new Section { SectionId = 2, Name = "Land Trip" },
                new Section { SectionId = 3, Name = "Cruise" }
                );

            builder.Entity<Trip>().HasData(
                new Trip { TripId = 1, Name = "Jordan", Description = "Palastine", StartDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-5)), EndDate = DateOnly.FromDateTime(DateTime.Today), StartTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(-5)), EndTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)), Price = 150, SectionId = 1 },
                new Trip { TripId = 2, Name = "Jordan", Description = "Turky", StartDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-2)), EndDate = DateOnly.FromDateTime(DateTime.Today), StartTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(-2)), EndTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)), Price = 450, SectionId = 1 },
                new Trip { TripId = 3, Name = "Jordan", Description = "Canada", StartDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-9)), EndDate = DateOnly.FromDateTime(DateTime.Today), StartTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)), EndTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(9)), Price = 650, SectionId = 1 },
                new Trip { TripId = 4, Name = "Jordan", Description = "Iraq", StartDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-5)), EndDate = DateOnly.FromDateTime(DateTime.Today), StartTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(-5)), EndTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)), Price = 150, SectionId = 2 },
                new Trip { TripId = 5, Name = "Jordan", Description = "Palastine", StartDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-2)), EndDate = DateOnly.FromDateTime(DateTime.Today), StartTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(-2)), EndTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)), Price = 450, SectionId = 2 },
                new Trip { TripId = 6, Name = "Jordan", Description = "Syria", StartDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-9)), EndDate = DateOnly.FromDateTime(DateTime.Today), StartTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)), EndTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(9)), Price = 650, SectionId = 2 },
                new Trip { TripId = 7, Name = "Jordan", Description = "Spain", StartDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-9)), EndDate = DateOnly.FromDateTime(DateTime.Today), StartTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)), EndTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(9)), Price = 650, SectionId = 3 },
                new Trip { TripId = 8, Name = "Jordan", Description = "USA", StartDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-2)), EndDate = DateOnly.FromDateTime(DateTime.Today), StartTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(-2)), EndTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(2)), Price = 450, SectionId = 3 },
                new Trip { TripId = 9, Name = "Jordan", Description = "UAE", StartDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-9)), EndDate = DateOnly.FromDateTime(DateTime.Today), StartTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(1)), EndTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(9)), Price = 650, SectionId = 3 }

                );

            builder.Entity<Company>().HasData(
                new Company { CompanyId=1,Email="Dalas@gmail.com",Name="Dalas",Location="Amman",Phone="0775426229"},
                new Company { CompanyId = 2, Email = "Moakeb@gmail.com", Name = "Moakeb", Location = "Amman", Phone = "0775422429" },
                new Company { CompanyId = 3, Email = "Petra@gmail.com", Name = "Petra", Location = "Amman", Phone = "0791122429" }
                );

            builder.Entity<TripCompany>().HasData(
                new TripCompany { TripCompanyId=1,Responsible="Asaad",CompanyId=1,TripId=1},
                new TripCompany { TripCompanyId = 2, Responsible = "Mohammad", CompanyId = 1, TripId = 2 ,Status=StatusEnum.Active},
                new TripCompany { TripCompanyId = 3, Responsible = "Karem", CompanyId = 2, TripId = 4, Status = StatusEnum.Active },
                new TripCompany { TripCompanyId = 4, Responsible = "Younes", CompanyId = 3, TripId = 9, Status = StatusEnum.Active }

                );

        }
        public DbSet<Eagle.Models.Company> tblCompany { get; set; } = default!;
        public DbSet<Eagle.Models.TripCompany> TripCompany { get; set; } = default!;




    }
}
