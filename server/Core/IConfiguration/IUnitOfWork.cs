using System.Threading.Tasks;

namespace server.Core.IConfiguration
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
