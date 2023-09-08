using HotelListingAPI.Data;

namespace HotelListingAPI.Contracts
{
    public interface ICountriesRespoitory : IGenericRepository<Country>
	{
		Task<Country> GetDetails(int id);
	} 
}

