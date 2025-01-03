using WebApi.Model;

namespace WebApi.Repository.Interfaces
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Task Delete (int id);
    }
}
