using EcsDataManager.Data;
using EcsDataManager.EFContracts;
using EcsDataManager.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcsDataManager.EFConcrete
{
    public class VpnCustomerManager : ICRUDManager<VpnCustomers>, IUpdateComment<VpnCustomers>, ICustomerUrlManager<CustomerUrl>
    {
        readonly ApplicationDbContext _appContext;

        public VpnCustomerManager(ApplicationDbContext appContext)
        {
            _appContext = appContext;
        }
        public async Task<int> Add(VpnCustomers entity, short ismain = 0)
        {
            _appContext.VpnCustomers.Add(entity);
            var res = await _appContext.SaveChangesAsync();
            return res;
        }

        public async Task<int> AddUrl(CustomerUrl entity, short ismain = 0)
        {
            if (ismain != 0)
            {
                entity.isMain = ismain;
            }
            _appContext.VpnCustomerUrl.Add(entity);
            var res = await _appContext.SaveChangesAsync();
            return res;
        }
        public Task<CustomerUrl> GetMainUrlById(int Id,short ismain=0)
        {
            return Task.FromResult(_appContext.VpnCustomerUrl
                       .FirstOrDefault(e => e.VpnCustomerId == Id && e.isMain==ismain));
        }
        public async Task<int> Update(CustomerUrl dbEntity,CustomerUrl entity )
        {
            dbEntity.link = entity.link;
            var res = await _appContext.SaveChangesAsync();
            return res;
        }
        public async Task<int> Change(VpnCustomers dbEntity, VpnCustomers entity)
        {
            dbEntity.CustomerName = entity.CustomerName;
            dbEntity.Tel = entity.Tel;
            dbEntity.Mobile = entity.Mobile;
            dbEntity.OwnerTeam = entity.OwnerTeam;
            dbEntity.ServiceType = entity.ServiceType;
            dbEntity.ServiceTopology = entity.ServiceTopology;
            dbEntity.AAAGroup = entity.AAAGroup;
            dbEntity.AccountManager = entity.AccountManager;
            dbEntity.AccessList = entity.AccessList;
            dbEntity.APN = entity.APN;
            dbEntity.IpHQ = entity.IpHQ;
            dbEntity.IpTunnel = entity.IpTunnel;
            dbEntity.WanIpRange = entity.WanIpRange;
            dbEntity.LanIpRange = entity.LanIpRange;
            dbEntity.VpnToolsName = entity.VpnToolsName;
            dbEntity.VRF = entity.VRF;

            var res = await _appContext.SaveChangesAsync();
            return res;
        }

        public async Task<int> ChangeComment(VpnCustomers dbEntity, VpnCustomers entity)
        {
            dbEntity.Comment = entity.Comment;
            var res = await _appContext.SaveChangesAsync();
            return res;
        }

        public async Task<int> Delete(VpnCustomers entity)
        {
            _appContext.VpnCustomers.Remove(entity);
            var res = await _appContext.SaveChangesAsync();
            return res;
        }

        public Task<VpnCustomers> Get(int id, short ismain = 0)
        {

            return Task.FromResult(_appContext.VpnCustomers
                        .FirstOrDefault(e => e.id == id));
        }

        public Task<List<VpnCustomers>> GetAll(short ismain = 0)
        {
            var res = Task.FromResult(_appContext.VpnCustomers.OrderByDescending(x => x.id).ToList());
            return res;
        }

       
    }
}
