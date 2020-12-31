using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using EcsDataManager.Entities;

namespace EcsDataManager.Contracts
{
    public interface ICustomer<T>
    {

        T GetCustomerById(int Id);
        Task<int> UpdateComment(T customers,int ctype);

    }
}
