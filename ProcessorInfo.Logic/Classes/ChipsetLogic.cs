﻿using ProcessorInfo.Logic.Interfaces;
using ProcessorInfo.Models;
using ProcessorInfo.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessorInfo.Logic.Classes
{
    public class ChipsetLogic : IChipsetLogic
    {
        IRepository<Chipset> repository;
        public ChipsetLogic(IRepository<Chipset> repo)
        {
            this.repository = repo;
        }
        public void Create(Chipset item)
        {
            this.repository.Create(item);
        }

        public void Delete(int id)
        {
            this.repository.Delete(id);
        }

        public Chipset Read(int id)
        {
            var chip = repository.Read(id);
            if (chip == null)
            {
                throw new ArgumentException("****There is no sudc chipset!****");
            }
            return chip;
        }

        public IEnumerable<Chipset> ReadAll()
        {
            return this.repository.ReadAll();
        }

        public void Update(Chipset item)
        {
            this.repository.Update(item);
        }
    }
}
