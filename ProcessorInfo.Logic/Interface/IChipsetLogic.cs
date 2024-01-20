using ProcessorInfo.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProcessorInfo.Logic.Interfaces
{
    public interface IChipsetLogic
    {
        void Create(Chipset item);
        void Delete(int id);
        Chipset Read(int id);
        IEnumerable<Chipset> ReadAll();
        void Update(Chipset item);
    }
}