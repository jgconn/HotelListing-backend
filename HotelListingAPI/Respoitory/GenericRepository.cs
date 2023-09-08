using System;
using HotelListingAPI.Contracts;
using HotelListingAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Respoitory
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public Task<T> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

