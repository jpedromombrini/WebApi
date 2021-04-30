using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Domain.Core.Interfaces.Repositories.Register
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task AddAsync(TEntity obj);
        Task UpdateAsync(TEntity obj);
        Task RemoveAsync(TEntity obj);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(Guid id);
    }
}