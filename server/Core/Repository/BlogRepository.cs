using server.Core.IRepository;
using server.Data;
using server.Models;

namespace server.Core.Repository
{
    public class BlogRepository : GenericRepository<Blog>, IBlogRepository
    {
        public BlogRepository(ApplicationDbContext dbContext) :
            base(dbContext)
        {
        }
    }
}
