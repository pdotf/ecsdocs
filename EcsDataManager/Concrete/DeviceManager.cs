using Dapper;
using EcsDataManager.Contracts;
using EcsDataManager.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace EcsDataManager.Concrete
{
    public class DeviceManager : IDeviceManager
    {
        private readonly IDapperManager _dapperManager;

        public DeviceManager(IDapperManager dapperManager)
        {
            _dapperManager = dapperManager;
        }
        public Task<int> AddDevice(DeviceList devices, int? ismain=null)
        {
            var dbPara = new DynamicParameters();
            //CustomerName,Tel,Mobile,OwnerTeam,ServiceType,ServiceTopology,AccountManager,IpHQ,AAAGroup,IpTunnel,WanIpRange,LanIpRange,VRF,VpnToolsName
            dbPara.Add("CustomerId", devices.CustomerId, DbType.Int32);
            dbPara.Add("RadioName", devices.RadioName, DbType.String);
            dbPara.Add("RadioIp", devices.RadioIp, DbType.String);
            dbPara.Add("RadioModel", devices.RadioModel, DbType.String);
            dbPara.Add("RadioMetroSite", devices.RadioMetroSite, DbType.String);
            dbPara.Add("IsAuto", devices.IsAuto, DbType.String);

            if (ismain == null)
            {
                dbPara.Add("IsMain", devices.IsMain, DbType.String);
            }
            else
            {
                dbPara.Add("IsMain", ismain, DbType.String);
            }




            var articleId = Task.FromResult(_dapperManager.Insert<int>(@"INSERT INTO 
             EcsDocs.dbo.DeviceList
             (CustomerId,RadioName,RadioIp,RadioModel,RadioMetroSite,IsAuto,IsMain)
            VALUES
            (@CustomerId,@RadioName,@RadioIp,@RadioModel,@RadioMetroSite,@IsAuto,@IsMain)",
                dbPara,
                commandType: CommandType.Text));
            return articleId;
        }



        public Task<int> Update(DeviceList devices)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Id", devices.Id, DbType.String);
            dbPara.Add("CustomerId", devices.CustomerId, DbType.Int32);
            dbPara.Add("RadioName", devices.RadioName, DbType.String);
            dbPara.Add("RadioIp", devices.RadioIp, DbType.String); dbPara.Add("RadioModel", devices.RadioModel, DbType.String);
            dbPara.Add("RadioMetroSite", devices.RadioMetroSite, DbType.String);
            dbPara.Add("IsAuto", devices.IsAuto, DbType.String);


            var updateDevice = Task.FromResult(_dapperManager.Update<int>("Sp_UpdateDevice",
                dbPara,
                commandType: CommandType.StoredProcedure));
            return updateDevice;
        }

        public Task<int> Count(string search)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int Id)
        {
            var delete = Task.FromResult(_dapperManager.Execute($"Delete [DeviceList] where ID = {Id}", null,
              commandType: CommandType.Text));
            return delete;
        }

        public Task<DeviceList> GetDeviceById(int Id)
        {
            var device = Task.FromResult(_dapperManager.Get<DeviceList>($"select * from [DeviceList] where ID = {Id}", null,
                    commandType: CommandType.Text));
            return device;
        }
        public Task<List<DeviceList>> GetDeviceByCustomerId(int Id)
        {
            using (var device = Task.FromResult(_dapperManager.GetAll<DeviceList>($"select * from [DeviceList] where CustomerId = {Id} and IsMain=0", null, commandType: CommandType.Text)))
            {
                return device;
            }
        }
        public Task<DeviceList> GetMainDeviceById(int Id)
        {
            var device = Task.FromResult(_dapperManager.Get<DeviceList>($"select * from [DeviceList] where CustomerId = {Id} and IsMain=1 ", null,
                      commandType: CommandType.Text));
            return device;
        }
    }
}
