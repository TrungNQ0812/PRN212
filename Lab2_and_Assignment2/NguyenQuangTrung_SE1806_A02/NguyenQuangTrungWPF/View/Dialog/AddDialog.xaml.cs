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

namespace NguyenQuangTrungWPF.View.Dialog
{
    /// <summary>
    /// Interaction logic for AddDialog.xaml
    /// </summary>
    public partial class AddDialog : System.Windows.Window
    {
        public readonly CustomerService _adminService;

        public AddDialog()
        {
            InitializeComponent();
            var customerContext = new DBContext();
            var customerRepo = new CustomerRepository(customerContext);
            _adminService = new CustomerService(customerRepo);
        }

        private void AddCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            string fullName = FullNameTextBox.Text;
            string telephone = TelephoneTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordBox.Text;

            if (BirthdayDatePicker.SelectedDate == null || BirthdayDatePicker.SelectedDate.Value.Year < DateTime.Now.Year - 10)
            {
                MessageBox.Show("Please select a valid Birthday.");
                return;
            }
            DateTime birthday = BirthdayDatePicker.SelectedDate.Value;

            if (StatusComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a Status.");
                return;
            }
            string statusText = (StatusComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            byte status = statusText == "Active" ? (byte)1 : (byte)0;

            var customer = new Customer
            {
                CustomerFullName = fullName,
                Telephone = telephone,
                EmailAddress = email,
                CustomerBirthday = birthday,
                CustomerStatus = status,
                Password = password
            };


            _adminService.AddCustomer(customer);

            MessageBox.Show("Add successfully");

            this.DialogResult = true;
            this.Close();
        }
    }
}
