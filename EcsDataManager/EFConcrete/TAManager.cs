using EcsDataManager.EFContracts;
using EcsDataManager.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EcsDataManager.EFConcrete
{
    public class TAManager : ICRUDManager<Coordinators>
    {
        public Task<int> Add(Coordinators entity, short ismain = 0)
        {
            throw new NotImplementedException();
        }

        public Task<int> Change(Coordinators dbEntity, Coordinators entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(Coordinators entity)
        {
            throw new NotImplementedException();
        }

        public Task<Coordinators> Get(int id, short ismain = 0)
        {
            throw new NotImplementedException();
        }

        public Task<List<Coordinators>> GetAll(short ismain = 0)
        {
            throw new NotImplementedException();
        }
    }
}
