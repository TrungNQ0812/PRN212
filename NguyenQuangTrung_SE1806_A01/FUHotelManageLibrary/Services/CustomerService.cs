using FUHotelManageLibrary.Model;
using FUHotelManageLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUHotelManageLibrary.Services
{
    public class CustomerService(CustomerRepository customerRepo)
    {
        private readonly CustomerRepository _customerRepo = customerRepo;

        public IEnumerable<Customer> GetAllCucstomers()
        {
            IEnumerable<Customer> customers = _customerRepo.GetAllCustomers();
            return customers;
        }

        public void AddCustomer(Customer customer)
        {
            _customerRepo.AddCustomer(customer);
        }

        public Customer GetCustomerByID(int id)
        {
            return _customerRepo.GetCustomerById(id);
        }

        public void DeleteCustmerByID(int id)
        {
            _customerRepo.DeleteCustomer(id);
        }

        public void UpdateCustomer(Customer customer)
        {
            _customerRepo.UpdateCustomer(customer);
        }

    }
}
