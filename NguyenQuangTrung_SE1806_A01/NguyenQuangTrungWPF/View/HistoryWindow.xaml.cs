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
    /// Interaction logic for HistoryWindow.xaml
    /// </summary>
    public partial class HistoryWindow : Window
    {
        private readonly BookingReservationService _bookingReservationService;
        public Customer currentCustomer;

        public HistoryWindow(Customer currentCus)
        {
            InitializeComponent();

            var bookingReservationContext = new DBContext();
            var bookingReservationRepo = new BookingReservationRepository(bookingReservationContext);
            _bookingReservationService = new BookingReservationService(bookingReservationRepo);
            BookingListView.ItemsSource = _bookingReservationService.GetBookingReservationByCustomerID(currentCus.CustomerID);
            currentCustomer = currentCus;
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new();
            login.Show();
            this.Close();
        }
    }
}
