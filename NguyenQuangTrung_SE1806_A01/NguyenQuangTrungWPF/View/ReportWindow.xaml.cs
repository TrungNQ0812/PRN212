using FUHotelManageLibrary.dal;
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
using NguyenQuangTrungWPF.View;
using NguyenQuangTrungWPF.View.Dialog;
using NguyenQuangTrungWPF;

namespace NguyenQuangTrungWPF.View
{
    /// <summary>
    /// Interaction logic for ReportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        private BookingDetailService _bookingDetailService;
        PieChart chart;

        public ReportWindow()
        {
            InitializeComponent();
            var bookingDetailContext = new DBContext();
            var bookingDetailRepo = new BookingDetailRepository(bookingDetailContext);
            _bookingDetailService = new BookingDetailService(bookingDetailRepo);

            DataGrid.ItemsSource = _bookingDetailService.GetAlls();

            chart = new PieChart();
            chart.Show();
        }

        private void RoomWindow_Click(object sender, RoutedEventArgs e)
        {
            RoomWindow room = new();
            room.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            room.Show();
            chart.Close();
            this.Close();
        }

        private void CustomerWindow_Click(object sender, RoutedEventArgs e)
        {
            Admin window = new();
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
            chart.Close();
            this.Close();
        }

        private void ReportWindow_Click(object sender, RoutedEventArgs e)
        {
            ReportWindow reportWindow = new ReportWindow();
            reportWindow.Show();
            chart.Close();
            this.Close();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            this.Close();
        }
    }
}
