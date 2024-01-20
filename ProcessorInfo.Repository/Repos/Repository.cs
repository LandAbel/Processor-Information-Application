using ProcessorInfo.Models;
using ProcessorInfo.Repository.Data;
using ProcessorInfo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessorInfo.Repository.Repos
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected ProcessorInfoDbContext ctx;

        public Repository(ProcessorInfoDbContext ctx)
        {
            this.ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));
        }

        public void Create(T item)
        {
            ctx.Set<T>().Add(item);
            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            ctx.Set<T>().Remove(Read(id));
            ctx.SaveChanges();
        }

        public IQueryable<T> ReadAll()
        {
            return ctx.Set<T>();
        }
        public abstract T Read(int id);

        public abstract void Update(T item);
    }
}
