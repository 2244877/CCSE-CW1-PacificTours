using System.ComponentModel.DataAnnotations;

namespace PacificTours.Models
{
    public class HotelBooking
    {
        [Key]
        public int Booking_id { get; set; }
        public string Hotel {  get; set; }
        public string Room { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set;}
    }
}
