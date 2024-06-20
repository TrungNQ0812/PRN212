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
    /// Interaction logic for UpdateRoom.xaml
    /// </summary>
    public partial class UpdateRoom : Window
    {
        private readonly RoomService _roomService;
        public RoomInformation subRoom;
        private int roomID = 0;
        private RoomInformation selectedRoom;

        public UpdateRoom(RoomInformation selectedRoom)
        {
            InitializeComponent();
            var daoContext = new DBContext();
            var roomRepo = new RoomRepository(daoContext);
            _roomService = new RoomService(roomRepo);

            RoomNumberTextBox.Text = selectedRoom.RoomNumber;
            RoomDescriptionTextBox.Text = selectedRoom.RoomDetailDescription;
            RoomMaxCapacityTextBox.Text = selectedRoom.RoomMaxCapacity.ToString();
            RoomStatus.SelectedIndex = selectedRoom.RoomStatus - 1;
            RoomTypeIDTextBox.Text = selectedRoom.RoomTypeID.ToString();
            RoomPricePerDate.Text = selectedRoom.RoomPricePerDay.ToString();

            roomID = selectedRoom.RoomID;
        }

        private void UpdateRoomButton_Click(object sender, RoutedEventArgs e)
        {
            string number = RoomNumberTextBox.Text;
            string description = RoomDescriptionTextBox.Text;
            int maxcapacity = Int32.Parse(RoomMaxCapacityTextBox.Text);

            string priceText = RoomPricePerDate.Text.Trim().Replace(',', '.');
            decimal price;
            if (!Decimal.TryParse(priceText, out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            if (RoomStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a Status.");
                return;
            }

            string statusText = (RoomStatus.SelectedItem as ComboBoxItem)?.Content.ToString();
            byte status = statusText == "Active" ? (byte)1 : (byte)0;

            int typeID = Int32.Parse(RoomTypeIDTextBox.Text);

            var room = new RoomInformation
            {
                RoomNumber = number,
                RoomDetailDescription = description,
                RoomMaxCapacity = maxcapacity,
                RoomPricePerDay = price,
                RoomStatus = status,
                RoomTypeID = typeID
            };

            room.RoomID = roomID;

            _roomService.UpdateRoom(room);
            subRoom = room;


            MessageBox.Show("Update successfully");

            this.DialogResult = true;
            this.Close();
        }
    }
}
