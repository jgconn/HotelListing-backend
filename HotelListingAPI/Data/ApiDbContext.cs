using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using HotelListingAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Data
{
	public class ApiDbContext: DbContext
	{
		public ApiDbContext(DbContextOptions<ApiDbContext> options) :
			base(options)
		{
		}

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Country>().HasData(
				new Country
				{
					Id = 1,
					Name = "New Zealand",
                    ShortName = "NZ"
				},
				new Country
                {
					Id = 2,
					Name = "United States",
					ShortName = "USA"

                },
                new Country
                {
                    Id = 3,
                    Name = "Australia",
                    ShortName = "AUS"

                }
            );
			modelBuilder.Entity<Hotel>().HasData(
				new Hotel
				{
					Id = 4,
					Name = "The Grand Hotel",
					Address = "Sydney",
					CountryId = 3,
					Rating = 4
				},
                new Hotel
                {
                    Id = 5,
                    Name = "The Deep",
                    Address = "Auckland",
                    CountryId = 1,
                    Rating = 5
                }
            );
		}
	}
}

