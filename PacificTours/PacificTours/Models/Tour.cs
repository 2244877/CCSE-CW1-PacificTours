using System.ComponentModel.DataAnnotations;

namespace PacificTours.Models
{
    public class Tour
    {
        [Key]
        public int Tour_Id { get; set; }
        public string TourName { get; set; }
        public string TourPrice { get; set; }
    }
}
