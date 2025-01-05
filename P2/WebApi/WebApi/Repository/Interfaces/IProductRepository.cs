using WebApi.Model;

namespace WebApi.Repository.Interfaces
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Task<List<Product>> GetAllWithUser();
        Task Delete (int id);
    }
}
