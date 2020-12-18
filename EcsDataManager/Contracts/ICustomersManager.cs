using EcsDataManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcsDataManager.Contracts
{
    public interface ICustomersManager : ICustomer
    {
        Task<int> Create(Customers customers);
        Task<int> Delete(int Id);
        Task<int> Count(string search);
        Task<int> Update(Customers customers);
        Task<Customers> GetById(int Id);
        Task<List<Customers>> ListAll(int skip, int take, string orderBy, string direction, string search);
        Task<List<Customers>> ListAllWithoutPaging(string orderBy, string direction, string search);
        Task<CustomerView> GetCustomerJoinjwithDeviceById(int Id);



    }
}
