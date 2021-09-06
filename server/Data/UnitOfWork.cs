using System.Threading.Tasks;
using server.Core.IConfiguration;

namespace server.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public Task CompleteAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
