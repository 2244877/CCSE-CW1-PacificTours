using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PacificTours.Pages.HotelBooking
{
    public class NewBookingModel : PageModel
    {
        public HotelBookingInfo hotelBookingInfo = new HotelBookingInfo();
        public String errorMessage = "";
        public String successMessage = "";
        public void OnGet()
        {
        }

       public void OnPost()
        {
            hotelBookingInfo.hotel = Request.Form["hotel"];
            hotelBookingInfo.room = Request.Form["room"];

            if (hotelBookingInfo.hotel.Length == 0 || hotelBookingInfo.room.Length == 0)
            {
                errorMessage = "All the fields are required";
                return;
            }

            // save booking information to the database

            hotelBookingInfo.hotel = ""; hotelBookingInfo.room = "";
            successMessage = "Booking Successfull";
        }
    }
}
