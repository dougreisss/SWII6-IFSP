using TP03_Douglas_Lucas.Models;

namespace TP03_Douglas_Lucas.Repository.Interface
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAll();
        Task<Product> GetById(int id);
        Task Insert(Product product);
        Task Update(Product product);
        Task DeleteAsync(int id);
    }
}
