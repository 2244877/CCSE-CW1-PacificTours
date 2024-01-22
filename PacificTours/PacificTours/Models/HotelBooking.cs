using System.ComponentModel.DataAnnotations;

namespace PacificTours.Models
{
    public class HotelBooking
    {
        [Key]
        public int Booking_Id { get; set; }
        [Required]
        public string Hotel { get; set; } = "";
        [Required]
        public string RoomType { get; set; } = "";
        [Required]
        public DateTime CheckInDate { get; set; }
        [Required]
        public DateTime CheckOutDate { get; set;}
    }
}
