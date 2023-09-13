using System;
using HotelListingAPI.Models.User;
using Microsoft.AspNetCore.Identity;

namespace HotelListingAPI.Contracts
{
	public interface IAuthManager
	{
		Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);

		Task<AuthResponseDto> Login(LoginDto login);

		Task<string> CreateRefreshToken();

		Task<AuthResponseDto> VerifyRefreshToken(AuthResponseDto request);
	}


}

