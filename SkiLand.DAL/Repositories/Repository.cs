using Microsoft.EntityFrameworkCore;
using SkiLand.Domain.Models;
using SkiLand.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkiLand.DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly DbContext _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        } 

        public async Task CreateAsync(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public async Task DeleteAsync(long id)
        {
            var entity = await FindById(id);

            if (entity != null)
            {
                await DeleteAsync(entity);
            }
        }

        public async Task<List<TEntity>> FindAll()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> FindById(long id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task SaveChanges()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
        }
    }
}
