using System.Threading.Tasks;
using AutoMapper;
using server.Core.IConfiguration;
using server.Core.IRepository;
using server.Core.Repository;

namespace server.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _dbContext;

        public IBlogRepository Blog { get; private set; }

        public ICommentRepository Comment {get;private set;}
        public UnitOfWork(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            Blog = new BlogRepository(_dbContext, mapper);
            Comment = new CommentRepository(_dbContext,mapper);
        }
        public async Task CompleteAsync()
        {
            await this._dbContext.SaveChangesAsync();
        }
    }
}
