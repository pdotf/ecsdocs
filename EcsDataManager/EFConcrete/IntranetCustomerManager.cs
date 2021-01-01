using EcsDataManager.DataAccess;
using EcsDataManager.EFContracts;
using EcsDataManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcsDataManager.EFConcrete
{
    public class IntranetCustomerManager : ICRUDManager<IntranetCustomers>, IUpdateComment<IntranetCustomers>
    {
        private readonly EcsContext _ecsContext;

        public IntranetCustomerManager(EcsContext ecsContext)
        {
            _ecsContext = ecsContext;
        }
        public async Task Add(IntranetCustomers entity)
        {
            _ecsContext.Add(entity);
            await _ecsContext.SaveChangesAsync();
        }

        public async Task Change(IntranetCustomers dbEntity, IntranetCustomers entity)
        {
            dbEntity.CustomerName = entity.CustomerName;
            dbEntity.Tell = entity.Tell;
            dbEntity.Mobile = entity.Mobile;
            dbEntity.OwnerTeam = entity.OwnerTeam;
            dbEntity.ServiceType = entity.ServiceType;
            dbEntity.IpRange = entity.IpRange;
            await _ecsContext.SaveChangesAsync();
        }

        public async Task ChangeComment(IntranetCustomers dbEntity, IntranetCustomers entity)
        {
            dbEntity.Comment = entity.Comment;
            await _ecsContext.SaveChangesAsync();

        }

        public async Task Delete(IntranetCustomers entity)
        {
            _ecsContext.Remove(entity);
            await _ecsContext.SaveChangesAsync();
        }

        public Task<IntranetCustomers> Get(int id)
        {
            return Task.FromResult(_ecsContext.IntranetCustomers
                        .FirstOrDefault(e => e.Id == id));
        }

        public Task<List<IntranetCustomers>> GetAll()
        {
            var res = Task.FromResult(_ecsContext.IntranetCustomers.ToList());
            return res;
        }
    }
}
