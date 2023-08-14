using Domain.Common;
using Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _context;
        internal DbSet<TEntity> _data;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _data = _context.Set<TEntity>();
        }
        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            var createEntity = await _data.AddAsync(entity);
            _context.SaveChanges();
           return  createEntity.Entity;
        }

        public async Task<TEntity> DeleteAsync(long id)
        {
            var delete = await _data.FindAsync(id);
            _context.Remove(delete);
            _context.SaveChanges();
            return delete;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _data.ToListAsync();
            
        }

        public async Task<TEntity> GetByIdAsync(long id)
        {
            return await _data.FindAsync(id);
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
