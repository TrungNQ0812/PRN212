using FUHotelManageLibrary.dal;
using FUHotelManageLibrary.Model;
using FUHotelManageLibrary.Repository;
using FUHotelManageLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NguyenQuangTrungWPF.View
{
    /// <summary>
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        private readonly CustomerService _customerService;
        public Customer currentCus;

        public CustomerWindow(Customer customer)
        {
            InitializeComponent();
            var customerContext = new DBContext();
            var customerRepo = new CustomerRepository(customerContext);
            _customerService = new CustomerService(customerRepo);

            FullNameTextBox.Text = customer.CustomerFullName;
            TelephoneTextBox.Text = customer.Telephone;
            EmailAddressTextBox.Text = customer.EmailAddress;
            BirthdayDatePicker.SelectedDate = customer.CustomerBirthday;
            PasswordBox.Text = customer.Password;

            currentCus = customer;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string fullName = FullNameTextBox.Text;
            string telephone = TelephoneTextBox.Text;
            string email = EmailAddressTextBox.Text;
            string password = PasswordBox.Text;

            if (BirthdayDatePicker.SelectedDate == null || BirthdayDatePicker.SelectedDate.Value.Year < DateTime.Now.Year - 10)
            {
                MessageBox.Show("Please select a valid Birthday.");
                return;
            }
            DateTime birthday = BirthdayDatePicker.SelectedDate.Value;

            var customer = new Customer
            {
                CustomerFullName = fullName,
                Telephone = telephone,
                EmailAddress = email,
                CustomerBirthday = birthday,
                CustomerStatus = currentCus.CustomerStatus,
                Password = password
            };

            customer.CustomerID = currentCus.CustomerID;

            _customerService.UpdateCustomer(customer);
            currentCus = customer;


            MessageBox.Show("Update successfully");
        }

        private void ProfileWindow_Click(object sender, RoutedEventArgs e)
        {
            CustomerWindow window = new(currentCus);
            window.Show();
            this.Close();
        }

        private void HistoryWindow_Click(object sender, RoutedEventArgs e)
        {
            HistoryWindow window = new(currentCus);
            window.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow window = new();
            window.Show();
            this.Close();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new();
            login.Show();
            this.Close();
        }
    }
}
