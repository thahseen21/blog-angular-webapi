using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using server.Core.IRepository;
using server.Data;

namespace server.Core.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected ApplicationDbContext dbContext;

        protected DbSet<T> dbSet;

        protected readonly IMapper _mapper;

        public GenericRepository(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<T>();
            this._mapper = mapper;
        }

        public async Task<IEnumerable<T>> All()
        {
            return await dbSet.ToListAsync<T>();
        }

        public async Task<bool> Add(T entity)
        {
            await dbSet.AddAsync(entity);
            return true;
        }

        public virtual async Task<T> Update(T entity)
        {
            throw new System.NotImplementedException();
        }

        public virtual async Task<bool> Delete(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
