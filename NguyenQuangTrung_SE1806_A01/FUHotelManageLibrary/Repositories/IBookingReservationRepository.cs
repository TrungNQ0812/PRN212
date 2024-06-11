using FUHotelManageLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUHotelManageLibrary.Repository
{
    interface IBookingReservationRepository
    {
        IEnumerable<BookingReservation> GetBookingReservationByCustomerID(int CustomerID);
    }
}
