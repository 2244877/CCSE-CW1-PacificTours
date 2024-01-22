using System.ComponentModel.DataAnnotations;

namespace PacificTours.Models
{
    public class Hotel
    {
        [Key]
        public int Hotel_Id { get; set; }
        public string HotelName { get; set; }
        public string SingleRoomPrice { get; set; }
        public string DoubleRoomPrice { get; set; }
        public string FamilyRoomPrice { get; set; }

        public virtual ICollection<HotelBooking>? HotelBookings { get; set; }
    }
}
