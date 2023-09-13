using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListingAPI.Data.Configurations
{
	public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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

