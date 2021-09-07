using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using server.Core.IRepository;
using server.Data;
using server.Models;

namespace server.Core.Repository
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<IEnumerable<Comment>> GetAllById(int id)
        {
            return await dbSet.Where(item => item.BlogIdFk == id).ToListAsync();
        }
    }
}