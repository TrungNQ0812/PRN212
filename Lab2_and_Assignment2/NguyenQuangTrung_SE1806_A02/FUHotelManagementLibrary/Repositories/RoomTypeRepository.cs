using FUHotelManageLibrary.dal;
using FUHotelManageLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUHotelManageLibrary.Repository
{
    public class RoomTypeRepository : IRoomTypeRepository
    {
        private readonly DBContext _context;

        public RoomTypeRepository(DBContext context)
        {
            _context = context;
        }

        public void Add(RoomType type)
        {
            _context.RoomType.Add(type);
        }

        public IEnumerable<RoomType> GetAll()
        {
            return _context.RoomType.ToList();
        }

        public RoomType GetById(int roomTypeId)
        {
            return _context.RoomType.FirstOrDefault(r => r.RoomTypeID == roomTypeId);
        }

        public void Update(RoomType type)
        {
            var existingRoom = _context.RoomType.FirstOrDefault(r => r.RoomTypeID == type.RoomTypeID);
            if (existingRoom != null)
            {
                existingRoom.RoomTypeName = type.RoomTypeName;
                existingRoom.TypeDescription = type.TypeDescription;
                existingRoom.TypeNote = type.TypeNote;
                _context.SaveChanges();
            }
        }
    }
}
