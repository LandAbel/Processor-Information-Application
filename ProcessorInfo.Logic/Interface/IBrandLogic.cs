using ProcessorInfo.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProcessorInfo.Logic.Interfaces
{
    public interface IBrandLogic
    {
        void Create(Brand item);
        void Delete(int id);
        Brand Read(int id);
        IEnumerable<Brand> ReadAll();
        void Update(Brand item);
    }
}