using EcsDataManager.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EcsDataManager.Contracts
{
    public interface ICustomerUrlManager
    {
        Task<int> AddUrl(CustomerUrl devices, int? ismain);
        Task<List<CustomerUrl>> GetUrlByCustomerId(int Id);
        Task<CustomerUrl> GetUrlById(int Id);
        Task<CustomerUrl> GetMainUrlById(int Id);
        Task<int> Update(CustomerUrl devices);
        Task<int> Delete(int Id);
        Task<int> Count(string search);
    }
}
