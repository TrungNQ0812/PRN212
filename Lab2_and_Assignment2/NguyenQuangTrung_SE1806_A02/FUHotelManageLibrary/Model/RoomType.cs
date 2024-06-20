using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUHotelManageLibrary.Model
{
    public class RoomType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomTypeID { get; set; }
        public required string RoomTypeName { get; set; }
        public required string TypeDescription { get; set; }
        public required string TypeNote { get; set; }
    }
}
