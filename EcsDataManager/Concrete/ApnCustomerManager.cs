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
    public class ApnCustomerManager : IApnCustomerManager<ApnCustomers>
    {
        private readonly IDapperManager _dapperManager;

        public ApnCustomerManager(IDapperManager dapperManager)
        {
            _dapperManager = dapperManager;
        }
        public Task<int> Count(string search)
        {
            var totArticle = Task.FromResult(_dapperManager.Get<int>($"select COUNT(*) from [ApnCustomers] WHERE CustomerName like '%{search}%'", null,
                    commandType: CommandType.Text));
            return totArticle;
        }

        public Task<int> Create(ApnCustomers customers)
        {

            var dbPara = new DynamicParameters();
            //CustomerName,Tel,Mobile,OwnerTeam,ServiceType,ServiceTopology,AccountManager,IpHQ,AAAGroup,IpTunnel,WanIpRange,LanIpRange,VRF,VpnToolsName
            dbPara.Add("CustomerName", customers.CustomerName, DbType.String);
            dbPara.Add("Tell", customers.Tell, DbType.String);
            dbPara.Add("Mobile", customers.Mobile, DbType.String);
            dbPara.Add("OwnerTeam", customers.OwnerTeam, DbType.String);
            dbPara.Add("WanIpRange", customers.WanIpRange, DbType.String);
            dbPara.Add("AccessList", customers.AccessList, DbType.String);
            dbPara.Add("NumberOfSimCard", customers.NumberOfSimCard, DbType.String);
            dbPara.Add("Comment", customers.Comment, DbType.String);


            var articleId = Task.FromResult(_dapperManager.Insert<int>(@"INSERT INTO 
             EcsDocs.dbo.ApnCustomers
             (CustomerName,Tell,Mobile,OwnerTeam,WanIpRange,AccessList,NumberOfSimCard,Comment)
            VALUES
            (@CustomerName,@Tell,@Mobile,@OwnerTeam,@WanIpRange,@AccessList,@NumberOfSimCard,@Comment);SELECT CAST(SCOPE_IDENTITY() as int)",
                            dbPara,
                            commandType: CommandType.Text));



            return articleId;
            //throw new NotImplementedException();
        }
        public Task<int> Delete(int Id)
        {
            var delete = Task.FromResult(_dapperManager.Execute($"Delete [ApnCustomers] where ID = {Id}", null,
                commandType: CommandType.Text));
            return delete;
        }

        public Task<ApnCustomers> GetById(int Id)
        {

            var article = Task.FromResult(_dapperManager.Get<ApnCustomers>($"select * from [ApnCustomers] where ID = {Id}", null,
                    commandType: CommandType.Text));
            return article;
        }

        public Task<List<ApnCustomers>> ListAll(int skip, int take, string orderBy, string direction, string search)
        {
            var articles = Task.FromResult(_dapperManager.GetAll<ApnCustomers>
               ($"SELECT * FROM [ApnCustomers] WHERE CustomerName like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return articles;
        }
        public Task<int> UpdateComment(ApnCustomers customers,int customertype)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Id", customers.Id, DbType.Int32);
            dbPara.Add("Comment", customers.Comment, DbType.String);
            
            dbPara.Add("CustomerType",customertype, DbType.Int32);

            var updateArticle = Task.FromResult(_dapperManager.Update<int>("Sp_UpdateCustomersComment",
              dbPara,
              commandType: CommandType.StoredProcedure));
            return updateArticle;

        }
        public Task<int> Update(ApnCustomers customers)
        {
            var dbPara = new DynamicParameters();
 dbPara.Add("Id", customers.Id, DbType.Int32);
            dbPara.Add("CustomerName", customers.CustomerName, DbType.String);
            dbPara.Add("Tell", customers.Tell, DbType.String);
            dbPara.Add("Mobile", customers.Mobile, DbType.String);
            dbPara.Add("OwnerTeam", customers.OwnerTeam, DbType.String);
            dbPara.Add("WanIpRange", customers.WanIpRange, DbType.String);
            dbPara.Add("AccessList", customers.AccessList, DbType.String);
            dbPara.Add("NumberOfSimCard", customers.NumberOfSimCard, DbType.String);
            dbPara.Add("Comment", customers.Comment, DbType.String);



            var updateArticle = Task.FromResult(_dapperManager.Update<int>("Sp_UpdateApnCustomer",
                dbPara,
                commandType: CommandType.StoredProcedure));
            return updateArticle;
        }

        public ApnCustomers GetCustomerById(int Id)
        {
            var article = _dapperManager.Get<ApnCustomers>($"select * from [ApnCustomers] where ID = {Id}", null,
                commandType: CommandType.Text);
            return article;
        }


        public Task<List<ApnCustomers>> ListAllWithoutPaging(string orderBy, string direction, string search)
        {
            var articles = Task.FromResult(_dapperManager.GetAll<ApnCustomers>
               ($"SELECT *,ROW_NUMBER() OVER(ORDER BY ID) AS RowNumber FROM [ApnCustomers]", null, commandType: CommandType.Text));
            return articles;
        }


    }
}
