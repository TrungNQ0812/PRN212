namespace Models
{
    public class Room
    {
        //public Room() { }
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public string RoomDetailDescription { get; set; }
        public int RoomMaxCapacity {  get; set; }
        public int RoomStatus { get; set; }
        public decimal RoomPricePerDay { get; set; }
        public int RoomTypeID { get; set; }
    }
}
