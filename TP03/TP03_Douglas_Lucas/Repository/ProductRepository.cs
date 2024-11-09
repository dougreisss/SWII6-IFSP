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

        public List<Product> GetAll()
        {
            return  _sqlContext.Product.AsNoTracking().ToList();
        }

        public Product GetById(int id)
        {
            return _sqlContext.Product.Find(id); 
        }

        public bool Insert(Product product)
        {
            try
            {
                _sqlContext.Add(product);
                _sqlContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Product product)
        {
            try
            {
                _sqlContext.Update(product);
                _sqlContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(Product product)
        {
            try
            {
                if (product != null)
                {
                    _sqlContext.Product.Remove(product);
                    _sqlContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
