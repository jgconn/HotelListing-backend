using System;
using HotelListingAPI.Contracts;
using HotelListingAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Respoitory
{
	public class HotelRepository : GenericRepository<Hotel>, IHotelsRepository
	{
        public HotelRepository(ApiDbContext context) : base(context)
        {
        }
    }
}

