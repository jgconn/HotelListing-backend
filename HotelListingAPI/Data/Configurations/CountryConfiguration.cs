using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListingAPI.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
        }
    }
}

