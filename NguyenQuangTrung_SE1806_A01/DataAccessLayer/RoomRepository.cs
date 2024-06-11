using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DataAccessLayer
{
    public class RoomRepository : IRoomRepository
    {
        private readonly List<Room> rooms = new List<Room>();

        public void addRoom(Room room)
            => rooms.Add(room);

        public void deleteRoom(int roomId) 
            => rooms.RemoveAll(r => r.RoomID == roomId);

        public IEnumerable<Room> GetAllRooms()
            => rooms;

        public Room GetRoomById(int roomId)
            => rooms.FirstOrDefault(r => r.RoomID == roomId);

        public void updateRoom(Room room)
        {
            var existingRoom = GetRoomById(room.RoomID);
            if (existingRoom != null)
            {
                existingRoom.RoomID = room.RoomID;
                existingRoom.RoomName = room.RoomName;
                existingRoom.RoomDetailDescription = room.RoomDetailDescription;
                existingRoom.RoomMaxCapacity = room.RoomMaxCapacity;
                existingRoom.RoomTypeID = room.RoomTypeID;
                existingRoom.RoomStatus = room.RoomStatus;
                existingRoom.RoomPricePerDay = room.RoomPricePerDay;
            }
        }
    }
}
