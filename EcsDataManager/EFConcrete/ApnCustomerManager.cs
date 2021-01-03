using EcsDataManager.Data;
using EcsDataManager.EFContracts;
using EcsDataManager.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcsDataManager.EFConcrete
{
    public class ApnCustomerManager : ICRUDManager<ApnCustomers>, IUpdateComment<ApnCustomers>
    {
        private readonly ApplicationDbContext _ecsContext;

        public ApnCustomerManager(ApplicationDbContext ecsContext)
        {
            _ecsContext = ecsContext;
        }

        public async Task<int> Add(ApnCustomers entity,short ismain=0)
        {

            _ecsContext.Add(entity);
            var res = await _ecsContext.SaveChangesAsync();
            return res;
        }

        public async Task<int> Change(ApnCustomers dbEntity, ApnCustomers entity)
        {
            dbEntity.CustomerName = entity.CustomerName;
            dbEntity.Tell = entity.Tell;
            dbEntity.Mobile = entity.Mobile;
            dbEntity.OwnerTeam = entity.OwnerTeam;
            dbEntity.NumberOfSimCard = entity.NumberOfSimCard;
            dbEntity.WanIpRange = entity.WanIpRange;
            dbEntity.AccessList = entity.AccessList;
            dbEntity.AccountManager = entity.AccountManager;
            var res = await _ecsContext.SaveChangesAsync();
            return res;

        }

        public async Task<int> ChangeComment(ApnCustomers dbEntity, ApnCustomers entity)
        {
            dbEntity.Comment = entity.Comment;
            var res = await _ecsContext.SaveChangesAsync(); return res;
        }

        public async Task<int> Delete(ApnCustomers entity)
        {
            _ecsContext.Remove(entity);
            var res = await _ecsContext.SaveChangesAsync();
            return res;
        }

        public Task<ApnCustomers> Get(int id,short ismain=0)
        {
            return Task.FromResult(_ecsContext.ApnCustomers
                      .FirstOrDefault(e => e.Id == id));
        }

        public Task<List<ApnCustomers>> GetAll(short ismain=0)
        {
            var res = Task.FromResult(_ecsContext.ApnCustomers.OrderByDescending(x => x.Id).ToList());
            return res;
        }
    }
}
