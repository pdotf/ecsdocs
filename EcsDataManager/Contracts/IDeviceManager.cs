using EcsDataManager.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EcsDataManager.Contracts
{
    public interface IDeviceManager
    {
        Task<int> AddDevice(DeviceList devices,int? ismain);
        Task<List<DeviceList>> GetDeviceByCustomerId(int Id);
        Task<DeviceList> GetDeviceById(int Id);
        Task<DeviceList> GetMainDeviceById(int Id);
        Task<int> Update(DeviceList devices);
        Task<int> Delete(int Id);
        Task<int> Count(string search);
    }
}
