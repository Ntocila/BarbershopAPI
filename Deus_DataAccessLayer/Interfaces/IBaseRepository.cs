using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deus_DataAccessLayer.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IList<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> CreateUpdate(T entity);
        Task<bool> Delete(T entity);
        Task<bool> SaveChanges();
        Task<bool> IsExists(int id);
    }
}
