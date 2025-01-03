using WebApi.Model;

namespace WebApi.Repository.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task Delete(int id);
        Task<User> Login(string name, string senha);
        Task<List<User>> GetUserByName(string name);
    }
}
