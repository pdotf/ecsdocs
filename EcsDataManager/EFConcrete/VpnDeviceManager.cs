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
    public class VpnDeviceManager : ICRUDManager<DeviceList>, IDeviceManager<DeviceList>
    {
        private readonly EcsContext _ecsContext;

        public VpnDeviceManager(EcsContext ecsContext)
        {
            _ecsContext = ecsContext;
        }

        public async Task<int> Add(DeviceList entity, short ismain = 0)
        {
            if (ismain != 0)
            {
                entity.IsMain = 1;
            }
            _ecsContext.Add(entity);
            var res = await _ecsContext.SaveChangesAsync();
            return res;
        }

        public async Task<int> Change(DeviceList dbEntity, DeviceList entity)
        {
            dbEntity.IsAuto = entity.IsAuto;
            dbEntity.IsMain = entity.IsMain;
            dbEntity.RadioIp = entity.RadioIp;
            dbEntity.RadioMetroSite = entity.RadioMetroSite;
            dbEntity.RadioModel = entity.RadioModel;
            dbEntity.RadioName = entity.RadioName;

            var res = await _ecsContext.SaveChangesAsync();
            return res;
        }

        public async Task<int> Delete(DeviceList entity)
        {
            _ecsContext.DeviceList.Remove(entity);
            var res = await _ecsContext.SaveChangesAsync();
            return res;
        }

        public Task<DeviceList> Get(int id, short ismain)
        {
            //  var test = _ecsContext.DeviceList.ToList(); 
            //.Where(e => e.Cus == id && e.IsMain==ismain).SingleOrDefault();
            var res = Task.FromResult(_ecsContext.DeviceList
                     .FirstOrDefault(e => e.CustomerId == id && e.IsMain == ismain));
            return res;
        }

        public Task<DeviceList> GetDevice(int id, short ismain = 0)  
        {
            var res = Task.FromResult(_ecsContext.DeviceList
                   .FirstOrDefault(e => e.Id == id && e.IsMain == ismain));
            return res;
        }

        public Task<List<DeviceList>> GetAll(short ismain = 0)
        {
            var res = Task.FromResult(_ecsContext.DeviceList.Where(w => w.IsMain == ismain).OrderByDescending(x => x.Id).ToList());
            return res;
        }
    }
}
