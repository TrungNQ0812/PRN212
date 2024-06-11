using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataAccessLayer
{
    public interface IRoomRepository
    {
        IEnumerable<Room> GetAllRooms();
        Room GetRoomById(int roomId);
        void addRoom(Room room);
        void updateRoom(Room room);
        void deleteRoom(int roomId);
    }
}
