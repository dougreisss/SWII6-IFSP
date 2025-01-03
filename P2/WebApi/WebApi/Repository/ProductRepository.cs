﻿using Microsoft.EntityFrameworkCore;
using WebApi.Context;
using WebApi.Model;
using WebApi.Repository.Interfaces;

namespace WebApi.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(SqlContext context) : base (context)
        {
            
        }

        public async override Task<Product> GetById(int id)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task Delete(int id)
        {
            var product = await GetById(id);
            await base.Delete(product);
        }
    }
}
