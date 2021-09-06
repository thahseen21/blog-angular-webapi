using System.Collections.Generic;
using System.Threading.Tasks;

namespace server.Core.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> All();

        Task<T> GetById(int id);

        Task<bool> Add(T entity);

        Task<bool> Update(T entity);

        Task<bool> Delete(T entity);
    }
}
