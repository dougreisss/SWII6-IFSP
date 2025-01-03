using Microsoft.EntityFrameworkCore;
using WebApi.Context;
using WebApi.Repository.Interfaces;

namespace WebApi.Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly DbSet<T> DbSet;
        protected readonly SqlContext SqlContext;
        public BaseRepository(SqlContext context)
        {
            SqlContext = context;
            DbSet = SqlContext.Set<T>();
        }

        public async Task<List<T>> GetAll()
        {
            return await DbSet.AsNoTracking().ToListAsync();
        }

        public abstract Task<T> GetById(int id);

        public async Task Create(T entity)
        {
            DbSet.Add(entity);  
            await SqlContext.SaveChangesAsync();    
        }

        public async Task Update(T entity)
        {
            DbSet.Update(entity);   
            await SqlContext.SaveChangesAsync();    
        }

        public async Task Delete(T entity)
        {
            DbSet.Remove(entity);
            await SqlContext.SaveChangesAsync();
        }
    }
}
