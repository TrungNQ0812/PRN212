using FUHotelManageLibrary.dal;
using FUHotelManageLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUHotelManageLibrary.Repository
{
    public class RoomRepository : IRoomRepository
    {

        private readonly DBContext _context;

        public RoomRepository(DBContext context)
        {
            _context = context;
        }

        public void Add(RoomInformation room)
        {
            _context.RoomInformation.Add(room);
            _context.SaveChanges();
        }

        public void Delete(int roomId)
        {
            var room = _context.RoomInformation.FirstOrDefault(r => r.RoomID == roomId);
            if (room != null)
            {
                room.RoomStatus = 0;
                _context.RoomInformation.Update(room);
                _context.SaveChanges();
            }
        }

        public IEnumerable<RoomInformation> GetAll()
        {
            return _context.RoomInformation.ToList();
        }

        public RoomInformation GetById(int roomId)
        {
            return _context.RoomInformation.FirstOrDefault(r => r.RoomID == roomId);
        }

        public void Update(RoomInformation room)
        {
            var existingRoom = _context.RoomInformation.FirstOrDefault(r => r.RoomID == room.RoomID);
            if (existingRoom != null)
            {
                existingRoom.RoomNumber = room.RoomNumber;
                existingRoom.RoomDetailDescription = room.RoomDetailDescription;
                existingRoom.RoomMaxCapacity = room.RoomMaxCapacity;
                existingRoom.RoomStatus = room.RoomStatus;
                existingRoom.RoomPricePerDay = room.RoomPricePerDay;
                existingRoom.RoomTypeID = room.RoomTypeID;

                _context.SaveChanges();
            }
        }
    }
}
