using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HotelListingAPI.Data.Configurations;

namespace HotelListingAPI.Data
{
    public class ApiDbContext : IdentityDbContext<ApiUser>
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

            modelBuilder.ApplyConfiguration(new RoleConfigurations());

            modelBuilder.ApplyConfiguration(new CountryConfiguration());

            modelBuilder.ApplyConfiguration(new HotelConfiguration());
        }
	}
}

