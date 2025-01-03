using Microsoft.EntityFrameworkCore;
using WebApi.Context;
using WebApi.Model;
using WebApi.Repository.Interfaces;

namespace WebApi.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(SqlContext context) : base (context)
        {
            
        }

        public async override Task<User> GetById(int id)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task Delete(int id)
        {
            var user = await GetById(id);
            await base.Delete(user);
        }

        public async Task<User> Login(string name, string password)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(u => u.Name == name && u.Password == password && u.Status);
        }

        public Task<List<User>> GetUserByName(string name)
        {
            return DbSet.AsTracking().Where(u => u.Name.Contains(name)).ToListAsync();
        }
    }
}
