using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data.Interfaces
{
    public interface IGenericRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T?> Get(Guid id);
        Task Add(T model);
        void Update(T model);
        void Delete(T model);
    }
}