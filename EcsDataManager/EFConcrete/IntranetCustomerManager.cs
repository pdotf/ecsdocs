using EcsDataManager.Data;
using EcsDataManager.EFContracts;
using EcsDataManager.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcsDataManager.EFConcrete
{
    public class IntranetCustomerManager : ICRUDManager<IntranetCustomers>, IUpdateComment<IntranetCustomers>
    {
        private readonly ApplicationDbContext _ecsContext;

        public IntranetCustomerManager(ApplicationDbContext ecsContext)
        {
            _ecsContext = ecsContext;
        }
        public async Task<int> Add(IntranetCustomers entity,short ismain=0)
        {
            _ecsContext.Add(entity);
            var res =await _ecsContext.SaveChangesAsync();
            return res;
        }

        public async Task<int> Change(IntranetCustomers dbEntity, IntranetCustomers entity)
        {
            dbEntity.CustomerName = entity.CustomerName;
            dbEntity.Tell = entity.Tell;
            dbEntity.Mobile = entity.Mobile;
            dbEntity.OwnerTeam = entity.OwnerTeam;
            dbEntity.ServiceType = entity.ServiceType;
            dbEntity.IpRange = entity.IpRange;
            dbEntity.AccountManager = entity.AccountManager;
            var res = await _ecsContext.SaveChangesAsync();
            return res;
        }

        public async Task<int> ChangeComment(IntranetCustomers dbEntity, IntranetCustomers entity)
        {
            dbEntity.Comment = entity.Comment;
            var res = await _ecsContext.SaveChangesAsync();
            return res;

        }

        public async Task<int> Delete(IntranetCustomers entity)
        {
            _ecsContext.Remove(entity);
            var res = await _ecsContext.SaveChangesAsync();
            return res;
        }

        public Task<IntranetCustomers> Get(int id,short ismain=0)
        {
            return Task.FromResult(_ecsContext.IntranetCustomers
                        .FirstOrDefault(e => e.Id == id));
        }

        public Task<List<IntranetCustomers>> GetAll(short ismain=0)
        {
            var res = Task.FromResult(_ecsContext.IntranetCustomers.OrderByDescending(x => x.Id).ToList());
            return res;
        }
    }
}
