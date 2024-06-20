using FUHotelManageLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUHotelManageLibrary.Repository
{
    interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int customerId);
        Customer GetCustomerById(int customerId);
        IEnumerable<Customer> GetAllCustomers();
    }
}
