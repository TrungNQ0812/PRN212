using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FUHotelManageLibrary.Model
{
    public class BookingReservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingReservationID { get; set; }

        public required DateTime BookingDate { get; set; }
        public required decimal TotalPrice { get; set; }
        public required int CustomerID { get; set; }
        public required byte BookingStatus { get; set; }
    }
}
