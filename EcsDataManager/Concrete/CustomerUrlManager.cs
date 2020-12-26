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
    public class CustomerUrlManager : ICustomerUrlManager
    {
        private readonly IDapperManager _dapperManager;

        public CustomerUrlManager(IDapperManager dapperManager)
        {
            _dapperManager = dapperManager;
        }

        public Task<int> AddUrl(CustomerUrl urls, int? ismain)
        {
            var dbPara = new DynamicParameters();

            dbPara.Add("id", urls.id, DbType.Int32);
            dbPara.Add("customerId", urls.customerId, DbType.Int32);
            dbPara.Add("link", urls.link, DbType.String);

            if (ismain == null)
            {
                dbPara.Add("IsMain", urls.isMain, DbType.String);
            }
            else
            {
                dbPara.Add("IsMain", ismain, DbType.String);
            }
            var urlId = Task.FromResult(_dapperManager.Insert<int>(@"INSERT INTO EcsDocs.dbo.CustomerUrl (CustomerId,link,IsMain) VALUES      (@CustomerId,@link,@isMain)",
                dbPara,
                commandType: CommandType.Text));
            return urlId;
        }

        public Task<int> Count(string search)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int Id)
        {
            var delete = Task.FromResult(_dapperManager.Execute($"Delete [CustomerUrl] where ID = {Id}", null,
            commandType: CommandType.Text));
            return delete;
        }

        public Task<CustomerUrl> GetMainUrlById(int Id)
        {
            var url = Task.FromResult(_dapperManager.Get<CustomerUrl>($"select * from [CustomerUrl] where CustomerId = {Id} and IsMain=1 ", null,
                      commandType: CommandType.Text));
            return url;
        }

        public Task<List<CustomerUrl>> GetUrlByCustomerId(int Id)
        {
            using var url = Task.FromResult(_dapperManager.GetAll<CustomerUrl>($"select * from [CustomerUrl] where CustomerId = {Id} and IsMain=0", null, commandType: CommandType.Text));
            return url;
        }

        public Task<CustomerUrl> GetUrlById(int Id)
        {
            var url = Task.FromResult(_dapperManager.Get<CustomerUrl>($"select * from [CustomerUrl] where ID = {Id}", null,
                   commandType: CommandType.Text));
            return url;
        }

        public Task<int> Update(CustomerUrl urls)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("id", urls.id, DbType.Int32);
            dbPara.Add("customerId", urls.customerId, DbType.Int32);
            dbPara.Add("link", urls.link, DbType.String);
            var updateUrl = Task.FromResult(_dapperManager.Update<int>("Sp_UpdateUrl",
                 dbPara,
                 commandType: CommandType.StoredProcedure));
            return updateUrl;
        }
    }
}
