using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Domain.Core.Interfaces.Repositories;
using WebAPI.Domain.Core.Interfaces.Services;

namespace WebAPI.Domain.Services.Services
{
    public abstract class BaseService<TEntity> :  IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;
        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }
        public virtual Task AddAsync(TEntity obj)
        {
            return _repository.AddAsync(obj);
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public Task<TEntity> GetByIdAsync(Guid id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task Remove(TEntity obj)
        {
            return _repository.RemoveAsync(obj);
        }

        public Task Update(TEntity obj)
        {
            return _repository.UpdateAsync(obj);
        }
    }
}