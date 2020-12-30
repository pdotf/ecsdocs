using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EcsDataManager.Contracts
{
    public interface IApnCustomerManager<T>
    {
        Task<int> Create(T customers);
        Task<int> Delete(int Id);
        Task<int> Update(T customers);
        Task<T> GetById(int Id);
        Task<List<T>> ListAllWithoutPaging(string orderBy, string direction, string search);
    }
}
