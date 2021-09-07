using System.Collections.Generic;
using System.Threading.Tasks;
using server.Models;

namespace server.Core.IRepository
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {
        Task<IEnumerable<Comment>> GetAllById(int id);
    }
}