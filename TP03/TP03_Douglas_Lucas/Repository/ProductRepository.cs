using Microsoft.EntityFrameworkCore;
using TP03_Douglas_Lucas.Models;
using TP03_Douglas_Lucas.Models.SqlContext;
using TP03_Douglas_Lucas.Repository.Interface;

namespace TP03_Douglas_Lucas.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly SqlContext _sqlContext;
        public ProductRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _sqlContext.Product.ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            return await _sqlContext.Product.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Insert(Product product)
        {
            _sqlContext.Add(product);
            await _sqlContext.SaveChangesAsync(); 
        }

        public async Task Update(Product product)
        {
            _sqlContext.Update(product);
            await _sqlContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _sqlContext.Product.FindAsync(id);

            if (product != null) 
            {
                _sqlContext.Product.Remove(product);
                await _sqlContext.SaveChangesAsync();
            }
        }
    }
}
