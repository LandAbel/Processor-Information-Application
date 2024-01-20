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
    public class BrandRepository : Repository<Brand>, IRepository<Brand>
    {
        public BrandRepository(ProcessorInfoDbContext ctx) : base(ctx)
        {
        }
        public override Brand Read(int id)
        {
            return ctx.Brands.FirstOrDefault(t => t.BrandId == id);
        }

        public override void Update(Brand item)
        {
            var old = Read(item.BrandId);
            foreach (var prop in old.GetType().GetProperties())
            {
                if (prop.GetAccessors().FirstOrDefault(t => t.IsVirtual) == null)
                {
                    prop.SetValue(old, prop.GetValue(item));
                }
            }
            ctx.SaveChanges();
        }
    }
}
