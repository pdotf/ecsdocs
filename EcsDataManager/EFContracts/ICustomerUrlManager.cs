using EcsDataManager.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EcsDataManager.EFContracts
{
    public interface ICustomerUrlManager<TEntity>
    {
        Task<int> AddUrl(TEntity entity, short ismain);
        //Task<List<CustomerUrl>> GetUrlByCustomerId(int Id);
        //Task<CustomerUrl> GetUrlById(int Id);
        Task<TEntity> GetMainUrlById(int Id,short ismain = 0);
        Task<int> Update(TEntity dbEntity,TEntity entity);
        //Task<int> Delete(int Id);
        //Task<int> Count(string search);
    }
}
