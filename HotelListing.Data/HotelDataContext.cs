using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace HotelListing.Data
{
	public class HotelDataContext: DbContext
	{
        public HotelDataContext(DbContextOptions<HotelDataContext> options) :
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        public DbSet<Hotel> Hotels { get; set; }
    }
}


