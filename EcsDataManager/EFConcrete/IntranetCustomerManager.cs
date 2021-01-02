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
        public void Add(IntranetCustomers entity)
        {
            _ecsContext.Add(entity);
              _ecsContext.SaveChanges();
        }

        public void Change(IntranetCustomers dbEntity, IntranetCustomers entity)
        {
            dbEntity.CustomerName = entity.CustomerName;
            dbEntity.Tell = entity.Tell;
            dbEntity.Mobile = entity.Mobile;
            dbEntity.OwnerTeam = entity.OwnerTeam;
            dbEntity.ServiceType = entity.ServiceType;
            dbEntity.IpRange = entity.IpRange;
              dbEntity.AccountManager = entity.AccountManager;
              _ecsContext.SaveChanges();
        }

        public void ChangeComment(IntranetCustomers dbEntity, IntranetCustomers entity)
        {
            dbEntity.Comment = entity.Comment;
              _ecsContext.SaveChangesAsync();

        }

        public void Delete(IntranetCustomers entity)
        {
            _ecsContext.Remove(entity);
              _ecsContext.SaveChangesAsync();
        }

        public Task<IntranetCustomers> Get(int id)
        {
            return Task.FromResult(_ecsContext.IntranetCustomers
                        .FirstOrDefault(e => e.Id == id));
        }

        public Task<List<IntranetCustomers>> GetAll()
        {
            var res = Task.FromResult(_ecsContext.IntranetCustomers.OrderByDescending(x=>x.Id).ToList());
            return res;
        }
    }
}
