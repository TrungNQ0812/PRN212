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
using View;
using Models;
using DataAccessLayer;
using Reposotories;

namespace NguyenQuangTrungWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RoomViewModel roomViewModel;
        private CustomerViewModel customerViewModel;

        public MainWindow()
        {
            InitializeComponent();
            InitializeViewModels();
            BindData();
        }

        private void InitializeViewModels()
        {
            // Giả sử bạn đã có sẵn repository
            IRoomRepository roomRepository = new RoomRepository();
            ICustomerRepository customerRepository = new CustomerRepository();

            roomViewModel = new RoomViewModel(roomRepository);
            customerViewModel = new CustomerViewModel(customerRepository);
        }

        private void BindData()
        {
            RoomsDataGrid.ItemsSource = roomViewModel.Rooms;
            CustomersDataGrid.ItemsSource = customerViewModel.Customers;
        }

        private void AddRoomButton_Click(object sender, RoutedEventArgs e)
        {
            // Mở popup để thêm phòng mới
        }

        private void UpdateRoomButton_Click(object sender, RoutedEventArgs e)
        {
            // Mở popup để cập nhật phòng
        }

        private void DeleteRoomButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedRoom = (Room)RoomsDataGrid.SelectedItem;
            if (selectedRoom != null)
            {
                roomViewModel.DeleteRoom(selectedRoom.RoomID);
            }
        }

        private void AddCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            // Mở popup để thêm khách hàng mới
        }

        private void UpdateCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            // Mở popup để cập nhật khách hàng
        }

        private void DeleteCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedCustomer = (Customer)CustomersDataGrid.SelectedItem;
            if (selectedCustomer != null)
            {
                customerViewModel.DeleteCustomer(selectedCustomer.CustomerID);
            }
        }
    }
}
