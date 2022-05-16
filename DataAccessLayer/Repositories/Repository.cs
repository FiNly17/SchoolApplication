using DataAccessLayer.IRepositories;
using Microsoft.EntityFrameworkCore;
using ObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class Repository<T> : IRepository<T> 
        where T : class
    {
        private readonly SchoolContext context;
        protected readonly DbSet<T> set;

        public Repository(SchoolContext context)
        {
            this.context = context;
            this.set = context.Set<T>();
        }

        public virtual async Task<T> CreateAsync(T item)
        {
            var entityEntry = await set.AddAsync(item);
            return entityEntry.Entity;
        }

        public virtual void Delete(Guid id)
        {
            T del_item = set.Find(id);
            if (del_item != null)
            {
                set.Remove(del_item);
            }
        }

        public virtual async Task<T> FindByIdAsync(Guid id)
        {
            return await set.FindAsync(id);
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await set.ToListAsync();
        }

        public void Update(T item)
        {
            context.Update(item);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
