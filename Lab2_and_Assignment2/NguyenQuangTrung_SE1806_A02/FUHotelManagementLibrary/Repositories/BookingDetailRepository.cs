using FUHotelManagementLibrary.DataAccessLayer;
using FUHotelManagementLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUHotelManageLibrary.Repository
{
    public class BookingDetailRepository
    {
        private readonly DBContext _context;

        public BookingDetailRepository(DBContext context)
        {
            _context = context;
        }

        public IEnumerable<BookingDetail> GetBookingDetailByRoomID(int RoomID)
        {
            return _context.BookingDetail.Where(b => b.RoomID == RoomID).ToList();
        }

        public IEnumerable<BookingDetail> GetBookingDetailByBookingReservationID(int BookingReservationID)
        {
            return _context.BookingDetail.Where(b => b.BookingReservationID == BookingReservationID).ToList();
        }

        public IEnumerable<BookingDetail> GetAlls()
        {
            return _context.BookingDetail.ToList();
        }
    }
}
