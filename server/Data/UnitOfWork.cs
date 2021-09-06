using System.Threading.Tasks;
using server.Core.IConfiguration;
using server.Core.IRepository;
using server.Core.Repository;

namespace server.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _dbContext;

        public IBlogRepository Blog {get;private set;}

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Blog = new BlogRepository(_dbContext);
        }

        public Task CompleteAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
