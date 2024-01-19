using System.ComponentModel.DataAnnotations;

namespace PacificTours.Models
{
    public class Hotel
    {
        [Key]
        [Required]
        public string HotelName { get; set; }
        public string SingleRoomPrice { get; set; }
        public string DoubleRoomPrice { get; set; }
        public string FamilyRoomPrice { get; set; }
        }
}
