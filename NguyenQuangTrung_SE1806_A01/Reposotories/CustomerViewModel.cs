using DataAccessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public class CustomerViewModel : INotifyPropertyChanged
    {
        private readonly ICustomerRepository customerRepository;
        private Customer selectedCustomer;

        public ObservableCollection<Customer> Customers { get; set; }

        public Customer SelectedCustomer
        {
            get { return selectedCustomer; }
            set
            {
                if (selectedCustomer != value)
                {
                    selectedCustomer = value;
                    OnPropertyChanged(nameof(SelectedCustomer));
                }
            }
        }

        public CustomerViewModel(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
            Customers = new ObservableCollection<Customer>(customerRepository.GetAllCustomers());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // CRUD Operations
        public void AddCustomer(Customer customer)
        {
            customerRepository.AddCustomer(customer);
            Customers.Add(customer);
            OnPropertyChanged(nameof(Customers));
        }

        public void UpdateCustomer(Customer customer)
        {
            customerRepository.UpdateCustomer(customer);
            var existingCustomer = Customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
            if (existingCustomer != null)
            {
                var index = Customers.IndexOf(existingCustomer);
                Customers[index] = customer;
                OnPropertyChanged(nameof(Customers));
            }
        }

        public void DeleteCustomer(int customerId)
        {
            customerRepository.DeleteCustomer(customerId);
            var customer = Customers.FirstOrDefault(c => c.CustomerID == customerId);
            if (customer != null)
            {
                Customers.Remove(customer);
                OnPropertyChanged(nameof(Customers));
            }
        }
    }
}
