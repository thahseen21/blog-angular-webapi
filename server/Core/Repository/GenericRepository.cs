using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using server.Core.IRepository;
using server.Data;

namespace server.Core.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected ApplicationDbContext dbContext;

        protected DbSet<T> dbSet;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<T>();
        }

        public async Task<IEnumerable<T>> All()
        {
            return await dbSet.ToListAsync<T>();
        }

        public virtual async Task<T> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> Add(T entity)
        {
            await dbSet.AddAsync(entity);
            return true;
        }

        public virtual async Task<bool> Update(T entity)
        {
            throw new System.NotImplementedException();
        }

        public virtual async Task<bool> Delete(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
