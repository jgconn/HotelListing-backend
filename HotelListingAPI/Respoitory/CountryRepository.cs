using System;
using HotelListingAPI.Contracts;
using HotelListingAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Respoitory
{
    public class CountryRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly ApiDbContext _context;

        public CountryRepository(ApiDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<Country> GetDetails(int id)
        {
            return await _context.Countries.Include(q => q.Hotels).FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}

