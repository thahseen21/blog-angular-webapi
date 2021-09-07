using System.Threading.Tasks;
using server.Core.IRepository;

namespace server.Core.IConfiguration
{
    public interface IUnitOfWork
    {
        IBlogRepository Blog { get; }

        ICommentRepository Comment {get;}
        Task CompleteAsync();
    }
}
