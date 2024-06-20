using FUHotelManageLibrary.Model;
using FUHotelManageLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUHotelManageLibrary.Services
{
    public class RoomService(RoomRepository roomRepo)
    {
        private readonly RoomRepository _roomRepo = roomRepo;

        public IEnumerable<RoomInformation> GetAllRooms()
        {
            IEnumerable<RoomInformation> rooms = _roomRepo.GetAll();
            return rooms;
        }

        public void AddRoom(RoomInformation room)
        {
            _roomRepo.Add(room);
        }

        public RoomInformation GetRoomByID(int id)
        {
            return _roomRepo.GetById(id);
        }

        public void DeleterRoomByID(int id)
        {
            _roomRepo.Delete(id);
        }

        public void UpdateRoom(RoomInformation room)
        {
            _roomRepo.Update(room);
        }
    }
}
