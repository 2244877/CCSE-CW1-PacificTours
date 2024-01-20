using Microsoft.EntityFrameworkCore;
using PacificTours.Models;
using PacificTours.Repository;

public interface IHotelBookingRepository
{
    IEnumerable<HotelBooking> GetHotelBookings();
    HotelBooking GetHotelBookingById(int Booking_Id);
    void InsertHotelBooking(HotelBooking hotelbooking);
    void DeleteHotelBooking(int Booking_Id);
    void UpdateHotelBooking(HotelBooking hotelbooking);
}
