using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Domain.Core.Interfaces.Repositories.Register;
using WebAPI.Infrastructure.Data;

namespace WebAPI.Infrastructure.Repository.Repositories.Register
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DataContext _context;
        public BaseRepository(DataContext context)
        {
            _context = context;
        }

        public virtual async Task AddAsync(TEntity obj)
        {
            try
            {
               await _context.Set<TEntity>().AddAsync(obj);
               await _context.SaveChangesAsync();
            }
            catch(Exception)
            {
                throw;
            }
            
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();   
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task RemoveAsync(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public async Task UpdateAsync(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Update(obj);
                await _context.SaveChangesAsync();
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}