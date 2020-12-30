using EcsDataManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcsDataManager.Contracts
{
    public interface ICustomersManager<T> : ICustomer <T>
    {
        Task<int> Create(T customers);
        Task<int> Delete(int Id);
        Task<int> Count(string search);
        Task<int> Update(T customers);
        Task<T> GetById(int Id);
        Task<List<T>> ListAll(int skip, int take, string orderBy, string direction, string search);
        Task<List<T>> ListAllWithoutPaging(string orderBy, string direction, string search);


    }
}
