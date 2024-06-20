using FUHotelManageLibrary.Model;
using FUHotelManageLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUHotelManageLibrary.Services
{
    public class BookingReservationService(BookingReservationRepository bookingReservationRepository)
    {
        private readonly BookingReservationRepository bookingReservationRepository = bookingReservationRepository;

        public IEnumerable<BookingReservation> GetBookingReservationByCustomerID(int customerID)
        {
            return bookingReservationRepository.GetBookingReservationByCustomerID(customerID);
        }
    }
}
