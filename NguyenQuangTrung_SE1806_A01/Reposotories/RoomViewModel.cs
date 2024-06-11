using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataAccessLayer;
using System.ComponentModel;
using System.Collections.ObjectModel;
namespace Reposotories
{
    public class RoomViewModel : INotifyPropertyChanged
    {
        private readonly IRoomRepository roomRepository;
        private Room selectedRoom;

        public ObservableCollection<Room> Rooms { get; set; }

        public Room SelectedRoom
        {
            get { return selectedRoom; }
            set
            {
                if (selectedRoom != value)
                {
                    selectedRoom = value;
                    OnPropertyChanged(nameof(SelectedRoom));
                }
            }
        }

        public RoomViewModel(IRoomRepository roomRepository)
        {
            this.roomRepository = roomRepository;
            Rooms = new ObservableCollection<Room>(roomRepository.GetAllRooms());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // CRUD Operations
        public void AddRoom(Room room)
        {
            roomRepository.addRoom(room);
            Rooms.Add(room);
            OnPropertyChanged(nameof(Rooms));
        }

        public void UpdateRoom(Room room)
        {
            roomRepository.updateRoom(room);
            var existingRoom = Rooms.FirstOrDefault(r => r.RoomID == room.RoomID);
            if (existingRoom != null)
            {
                var index = Rooms.IndexOf(existingRoom);
                Rooms[index] = room;
                OnPropertyChanged(nameof(Rooms));
            }
        }

        public void DeleteRoom(int roomId)
        {
            roomRepository.deleteRoom(roomId);
            var room = Rooms.FirstOrDefault(r => r.RoomID == roomId);
            if (room != null)
            {
                Rooms.Remove(room);
                OnPropertyChanged(nameof(Rooms));
            }
        }
    }
}
