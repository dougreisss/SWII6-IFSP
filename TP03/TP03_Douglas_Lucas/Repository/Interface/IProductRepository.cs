using TP03_Douglas_Lucas.Models;

namespace TP03_Douglas_Lucas.Repository.Interface
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product GetById(int id);
        bool Insert(Product product);
        bool Update(Product product);
        bool Delete(Product product);
    }
}
