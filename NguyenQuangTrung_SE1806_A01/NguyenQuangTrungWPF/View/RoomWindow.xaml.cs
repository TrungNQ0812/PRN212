using FUHotelManageLibrary.dal;
using FUHotelManageLibrary.Model;
using FUHotelManageLibrary.Repository;
using FUHotelManageLibrary.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using NguyenQuangTrungWPF.View.Dialog;

namespace NguyenQuangTrungWPF.View
{
    /// <summary>
    /// Interaction logic for RoomWindow.xaml
    /// </summary>
    public partial class RoomWindow : Window
    {
        private readonly RoomService _roomService;
        private readonly RoomTypeService _roomTypeService;
        private ObservableCollection<RoomInformation> _rooms;
        private ObservableCollection<RoomType> _roomTypes;

        public RoomWindow()
        {
            InitializeComponent();
            var daoContext = new DBContext();
            var roomRepo = new RoomRepository(daoContext);
            _roomService = new RoomService(roomRepo);
            _rooms = new ObservableCollection<RoomInformation>((IEnumerable<RoomInformation>)_roomService.GetAllRooms());
            RoomDataGrid.ItemsSource = _rooms;

            var roomTypeRepo = new RoomTypeRepository(daoContext);
            _roomTypeService = new RoomTypeService(roomTypeRepo);
            _roomTypes = new ObservableCollection<RoomType>();
        }

        private void RefreshCustomerList()
        {
            _rooms.Clear();
            foreach (var room in _roomService.GetAllRooms())
            {
                _rooms.Add(room);
            }
        }

        private void AddRoomButton_Click(object sender, RoutedEventArgs e)
        {
            AddRoom addDialog = new();
            addDialog.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            bool? result = addDialog.ShowDialog();

            if (result == true)
            {
                RefreshCustomerList();
            }
        }

        private void UpdateRoomButton_Click(object sender, RoutedEventArgs e)
        {
            if (RoomDataGrid.SelectedItem is RoomInformation selectedRoom)
            {
                UpdateRoom updateDialog = new UpdateRoom(selectedRoom);
                updateDialog.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                var result = updateDialog.ShowDialog();

                int index = _rooms.IndexOf(selectedRoom);

                if (index != -1)
                {
                    _rooms[index] = updateDialog.subRoom;
                }
            }
            else
            {
                MessageBox.Show("Please select a room to update.");
            }
        }

        private void DeleteRoomButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedRoom = RoomDataGrid.SelectedItem as RoomInformation;
            if (selectedRoom == null)
            {
                MessageBox.Show("Please select a room to delete.");
                return;
            }

            var result = MessageBox.Show($"Are you sure you want to delete room {selectedRoom.RoomNumber}?",
                                         "Confirmation",
                                         MessageBoxButton.YesNo,
                                         MessageBoxImage.Question);

            MessageBox.Show("Delete Successfully");

            if (result == MessageBoxResult.Yes)
            {
                _roomService.DeleterRoomByID(selectedRoom.RoomID);

                foreach (var child in RoomPanel.Children)
                {
                    if (child is TextBox textBox)
                    {
                        textBox.Clear();
                    }
                    else if (child is DatePicker datePicker)
                    {
                        datePicker.SelectedDate = null;
                    }
                    else if (child is ComboBox comboBox)
                    {
                        comboBox.SelectedIndex = 0;
                    }
                }

                RefreshCustomerList();
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string keyword = SearchTextBox.Text.Trim();
            List<RoomInformation> results = _rooms.Where(r => r.RoomNumber.Contains(keyword)).ToList();

            // Update ListBox with search results
            RoomDataGrid.ItemsSource = results;
        }

        private void RoomDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (RoomDataGrid.SelectedItem is RoomInformation selectedRoom)
            {
                RoomType roomType = _roomTypeService.GetRoomTypeByID(selectedRoom.RoomTypeID);

                RoomIDTextBox.Text = selectedRoom.RoomID.ToString();
                RoomNumberTextBox.Text = selectedRoom.RoomNumber;
                RoomDescriptionTextBox.Text = selectedRoom.RoomDetailDescription;
                RoomMaxCapacityTextBox.Text = selectedRoom.RoomMaxCapacity.ToString();
                RoomStatus.SelectedIndex = selectedRoom.RoomStatus - 1;
                RoomPricePerDay.Text = selectedRoom.RoomPricePerDay.ToString();

                RoomTypeNameTextBox.Text = roomType.RoomTypeName;
                TypeDescriptionTextBox.Text = roomType.TypeDescription;
                TypeNoteTextBox.Text = roomType.TypeDescription;
            }
        }

        private void RoomWindow_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

            RoomWindow room = new();
            room.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            room.Show();
            this.Close();
        }

        private void ReportWindow_Click(object sender, RoutedEventArgs e)
        {
            ReportWindow window = new();
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
            this.Close();
        }

        private void CustomerWindow_Click(object sender, RoutedEventArgs e)
        {
            Admin window = new();
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
            this.Close();

            PieChart chart = new();
            chart.Close();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new();
            login.Show();
            this.Close();
        }
    }
}
