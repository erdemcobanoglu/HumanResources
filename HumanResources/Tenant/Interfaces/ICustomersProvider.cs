using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tenant.Model;

namespace Tenant.Interfaces
{
    public interface ICustomersProvider
    {
        Task<(bool IsSuccess, IEnumerable<Customer> Customers, string ErrorMessage)> GetCustomersAsync();
        Task<(bool IsSuccess, Customer Customer, string ErrorMessage)> GetCustomerAsync(int id);
        Task<(bool IsSuccess, Customer Customer, string ErrorMessage)> AddCustomerAsync(Customer customer);
    }
}
