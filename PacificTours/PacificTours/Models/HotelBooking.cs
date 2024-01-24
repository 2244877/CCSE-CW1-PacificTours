using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace PacificTours.Models
{
    public class HotelBooking
    {
        [Key]
        public int Booking_Id { get; set; }
        public string User_Id { get; set; }
        [Required]
        public int Hotel_Id { get; set; } 
        public virtual Hotel? Hotel { get; set; }
        [Required]
        public string RoomType { get; set; } = "";
        [Required]
        public DateTime CheckInDate { get; set; }
        [Required]
        public DateTime CheckOutDate { get; set; }
    }
}
