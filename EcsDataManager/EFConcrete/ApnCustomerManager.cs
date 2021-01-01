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
    public class ApnCustomerManager : ICRUDManager<ApnCustomers>, IUpdateComment<ApnCustomers>
    {
        private readonly EcsContext _ecsContext;

        public ApnCustomerManager(EcsContext ecsContext)
        {
            _ecsContext = ecsContext;
        }

        public void Add(ApnCustomers entity)
        {
            _ecsContext.Add(entity);
             _ecsContext.SaveChanges();
        }

        public void Change(ApnCustomers dbEntity, ApnCustomers entity)
        {
            dbEntity.CustomerName = entity.CustomerName;
            dbEntity.Tell = entity.Tell;
            dbEntity.Mobile = entity.Mobile;
            dbEntity.OwnerTeam = entity.OwnerTeam;
            dbEntity.NumberOfSimCard = entity.NumberOfSimCard;
            dbEntity.WanIpRange = entity.WanIpRange;
            dbEntity.AccessList = entity.AccessList;
            dbEntity.AcountManager = entity.AcountManager;
              _ecsContext.SaveChanges();
        }

        public void ChangeComment(ApnCustomers dbEntity, ApnCustomers entity)
        {
            dbEntity.Comment = entity.Comment;
             _ecsContext.SaveChanges();
        }

        public void Delete(ApnCustomers entity)
        {
            _ecsContext.Remove(entity);
             _ecsContext.SaveChanges();
        }

        public Task<ApnCustomers> Get(int id)
        {
            return Task.FromResult(_ecsContext.ApnCustomers
                      .FirstOrDefault(e => e.Id == id));
        }

        public Task<List<ApnCustomers>> GetAll()
        {
            var res = Task.FromResult(_ecsContext.ApnCustomers.OrderByDescending(x => x.Id).ToList());
            return res;
        }
    }
}
