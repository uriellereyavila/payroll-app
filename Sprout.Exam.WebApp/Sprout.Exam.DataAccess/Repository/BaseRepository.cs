using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sprout.Exam.DataAccess.Interface;

namespace Sprout.Exam.DataAccess.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly DbSet<TEntity> DBSet;
        protected ApplicationDbContext context;

        public BaseRepository(ApplicationDbContext context)
        {
            this.context = context;
            this.DBSet = context.Set<TEntity>();
        }

        public virtual async Task<TEntity> AddAsync(TEntity obj, bool autoSave = true)
        {
            DBSet.Add(obj);
            if (autoSave)
            {
                await SaveChangesAsync();
            }
            return obj;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await DBSet.AsQueryable().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await DBSet.FindAsync(id);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await this.context.SaveChangesAsync();
        }

        public Task UpdateAsync(TEntity obj, bool autoSave = true)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.context != null)
                {
                    this.context.Dispose();
                    this.context = null;
                }
            }
        }
    }
}
