using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> customers = new List<Customer>();
        
        public void AddCustomer(Customer customer) 
            => customers.Add(customer);

        public void DeleteCustomer(int customerId) 
            => customers.RemoveAll(r => r.CustomerID == customerId);

        public IEnumerable<Customer> GetAllCustomers() 
            => customers;

        public Customer GetCustomerById(int customerId) 
            => customers.FirstOrDefault(c => c.CustomerID == customerId);

        public void UpdateCustomer(Customer customer)
        {
            var existingCustomer = GetCustomerById(customer.CustomerID);
            if (existingCustomer != null)
            {
                //existingCustomer.CustomerID = customer.CustomerID;
                existingCustomer.CustomerFullName = customer.CustomerFullName;
                existingCustomer.Telephone = customer.Telephone;
                existingCustomer.EmailAddress = customer.EmailAddress;
                existingCustomer.CustomerBirthday = customer.CustomerBirthday;
                existingCustomer.CustomerStatus = customer.CustomerStatus;
                existingCustomer.Password = customer.Password;
            }
        }
    }
}
