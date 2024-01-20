using ProcessorInfo.Models;
using ProcessorInfo.Repository.Data;
using ProcessorInfo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ProcessorInfo.Repository.Repos
{
    public class ProcessorRepository:Repository<Processor>, IRepository<Processor>
    {
        public ProcessorRepository(ProcessorInfoDbContext ctx) : base(ctx)
        {
        }

        public override Processor Read(int id)
        {
            return ctx.Processors.FirstOrDefault(t => t.ProcessorId == id);
        }

        public override void Update(Processor item)
        {
            var old = Read(item.ProcessorId);
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
