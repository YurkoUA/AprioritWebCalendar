﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AprioritWebCalendar.Data.Interfaces;

namespace AprioritWebCalendar.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        #region Find.

        public async Task<IQueryable<TEntity>> FindAllAsync()
        {
            return await Task.Run(() => _context.Set<TEntity>());
        }

        public async Task<IQueryable<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Task.Run(() => _context.Set<TEntity>().Where(predicate));
        }

        public async Task<IQueryable<TEntity>> FindAllIncludingAsync(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var all = await FindAllAsync();

            foreach (var prop in includeProperties)
            {
                all = all.Include(prop);
            }
            return all;
        }

        public async Task<IQueryable<TEntity>> FindAllIncludingAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var all = await FindAllAsync(predicate);

            foreach (var prop in includeProperties)
            {
                all = all.Include(prop);
            }
            return all;
        }

        public async Task<IQueryable<TEntity>> FindAllIncludingAsync(Expression<Func<TEntity, bool>> predicate, params string[] includeProperties)
        {
            var all = await FindAllAsync(predicate);

            foreach (var prop in includeProperties)
            {
                all = all.Include(prop);
            }
            return all;
        }

        public async Task<TEntity> FindByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> FindByKeysAsync(params object[] values)
        {
            return await _context.Set<TEntity>().FindAsync(values);
        }

        #endregion

        #region Count.

        public async Task<int> CountAsync()
        {
            return await _context.Set<TEntity>().CountAsync();
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().CountAsync(predicate);
        }

        #endregion

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().AnyAsync(predicate);
        }

        #region Create, Update, Remove.

        public async Task<TEntity> CreateAsync(TEntity item)
        {
            return (await _context.Set<TEntity>().AddAsync(item)).Entity;
        }

        public async Task UpdateAsync(TEntity item)
        {
            await Task.Run(() => _context.Entry(item).State = EntityState.Modified);
        }

        public async Task RemoveAsync(TEntity item)
        {
            await Task.Run(() => _context.Set<TEntity>().Remove(item));
        }

        public async Task RemoveRangeAsync(IEnumerable<TEntity> items)
        {
            await Task.Run(() => _context.Set<TEntity>().RemoveRange(items));
        }

        public async Task RemoveRangeAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var dbset = _context.Set<TEntity>();
            var entitiesToDelete = dbset.Where(predicate);
            await RemoveRangeAsync(entitiesToDelete);
        }

        #endregion

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
