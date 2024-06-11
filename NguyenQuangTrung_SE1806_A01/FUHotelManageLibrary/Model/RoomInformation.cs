using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FUHotelManageLibrary.Model
{
    public class RoomInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomID { get; set; }

        public required string RoomNumber { get; set; }
        public required string RoomDetailDescription { get; set; }
        public required int RoomMaxCapacity { get; set; }
        public required byte RoomStatus { get; set; }
        public required decimal RoomPricePerDay { get; set; }
        public required int RoomTypeID { get; set; }
    }
}
