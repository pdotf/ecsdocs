using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using EcsDataManager.Entities;

namespace EcsDataManager.Contracts
{
    public interface ICustomer
    {

        Customers GetCustomerById(int Id);

    }
}
