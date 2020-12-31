using EcsDataManager.EFContracts;
using EcsDataManager.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using EcsDataManager.DataAccess;
using System.Linq;
using System.Threading.Tasks;

namespace EcsDataManager.EFConcrete
{
    public class VpnCustomerManager : ICRUDManager<Customers>,IUpdateComment<Customers>
    {
        readonly EcsContext _appContext;

        public VpnCustomerManager(EcsContext appContext)
        {
            _appContext = appContext;
        }
        public void Add(Customers entity)
        {
            _appContext.Customers.Add(entity);
            _appContext.SaveChanges();
        }

        public void Change(Customers dbEntity, Customers entity)
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

            _appContext.SaveChanges();
        }

        public void ChangeComment(Customers dbEntity, Customers entity)
        {
            dbEntity.Comment = entity.Comment;
            _appContext.SaveChanges();
        }

        public void Delete(Customers entity)
        {
            _appContext.Customers.Remove(entity);
            _appContext.SaveChanges();
        }

        public Customers Get(int id)
        {
            return _appContext.Customers
            .FirstOrDefault(e => e.id == id);
        }

        public IEnumerable<Customers> GetAll()
        {
            return _appContext.Customers.ToList();
        }

        Task<Customers> ICRUDManager<Customers>.Get(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Customers>> ICRUDManager<Customers>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
