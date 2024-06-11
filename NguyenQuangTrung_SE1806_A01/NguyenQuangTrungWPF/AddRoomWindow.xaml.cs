using Models;
using Reposotories;
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

namespace NguyenQuangTrungWPF
{
    /// <summary>
    /// Interaction logic for AddRoomWindow.xaml
    /// </summary>
    public partial class AddRoomWindow : Window
    {
        private RoomViewModel roomViewModel;

        public AddRoomWindow(RoomViewModel roomViewModel)
        {
            InitializeComponent();
            this.roomViewModel = roomViewModel;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var room = new Room
            {
                RoomName = RoomNumberTextBox.Text,
                RoomDetailDescription = DescriptionTextBox.Text,
                RoomMaxCapacity = int.Parse(CapacityTextBox.Text),
                RoomPricePerDay  = decimal.Parse(PriceTextBox.Text),
                RoomStatus = 1, // Giả sử 1 là trạng thái hoạt động
                RoomTypeID = 1 // Giả sử bạn có một loại phòng cụ thể
            };

            roomViewModel.AddRoom(room);
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
