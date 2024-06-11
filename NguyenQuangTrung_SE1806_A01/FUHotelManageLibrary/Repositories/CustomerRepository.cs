using FUHotelManageLibrary.dal;
using FUHotelManageLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUHotelManageLibrary.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DBContext _context;

        public CustomerRepository(DBContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _context.Customer.ToList();
        }

        public Customer GetCustomerById(int id)
        {
            return _context.Customer.FirstOrDefault(c => c.CustomerID == id);
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customer.Add(customer);
            _context.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            var existingCustomer = _context.Customer.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
            if (existingCustomer != null)
            {
                existingCustomer.CustomerFullName = customer.CustomerFullName;
                existingCustomer.Telephone = customer.Telephone;
                existingCustomer.EmailAddress = customer.EmailAddress;
                existingCustomer.CustomerBirthday = customer.CustomerBirthday;
                existingCustomer.CustomerStatus = customer.CustomerStatus;
                existingCustomer.Password = customer.Password;

                _context.SaveChanges();
            }
        }

        public void DeleteCustomer(int id)
        {
            var customer = _context.Customer.FirstOrDefault(c => c.CustomerID == id);
            if (customer != null)
            {
                customer.CustomerStatus = 0;
                _context.Customer.Update(customer);
                _context.SaveChanges();
            }
        }

        public Customer GetCustomerByEmailAndPassword(string email, string password)
        {
            Customer customer = _context.Customer.FirstOrDefault(c => c.EmailAddress == email && c.Password == password);
            return customer;
        }
    }
}
