using FUHotelManageLibrary.dal;
using FUHotelManageLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUHotelManageLibrary.Repository
{
    public class BookingReservationRepository : IBookingReservationRepository
    {
        private readonly DBContext _context;

        public BookingReservationRepository(DBContext context)
        {
            _context = context;
        }

        public IEnumerable<BookingReservation> GetBookingReservationByCustomerID(int CustomerID)
        {
            // Return many items
            return _context.BookingReservation.Where(b => b.CustomerID == CustomerID).ToList();
        }
    }
}