using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace PacificTours.Models
{
    public class TourBooking
    {
        [Key]
        public int TourBooking_Id { get; set; }
        public string User_Id { get; set; }
        [Required]
        public int Tour_Id { get; set; } 
        public virtual Tour? Tour { get; set; }
        [Required]
        public DateTime CheckInDate { get; set; }
        [Required]
        public DateTime CheckOutDate { get; set; }
    }
}