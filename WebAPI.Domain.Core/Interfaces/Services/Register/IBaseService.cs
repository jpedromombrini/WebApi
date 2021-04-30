using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Domain.Core.Interfaces.Services.Register
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        Task AddAsync(TEntity obj);
        Task<TEntity> GetByIdAsync(Guid id);        
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task UpdateAsync(TEntity obj);
        Task RemoveAsync(TEntity obj);        
    }
}