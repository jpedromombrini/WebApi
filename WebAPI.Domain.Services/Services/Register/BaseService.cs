using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Domain.Core.Interfaces.Repositories.Register;
using WebAPI.Domain.Core.Interfaces.Services.Register;

namespace WebAPI.Domain.Services.Services.Register
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

        public Task RemoveAsync(TEntity obj)
        {
            return _repository.RemoveAsync(obj);
        }

        public Task UpdateAsync(TEntity obj)
        {
            return _repository.UpdateAsync(obj);
        }
    }
}