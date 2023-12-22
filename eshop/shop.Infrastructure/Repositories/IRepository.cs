using eshop.Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Infrastructure.Repositories
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        IEnumerable<T> Get();
        T GetById(int id);

        void Create(T entity);
        void Update(T entity);
        void Delete(int id);

        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);

        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);

    }
}
