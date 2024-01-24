using Microsoft.EntityFrameworkCore;
using PacificTours.Models;
using PacificTours.Repository;

public interface ITourBookingRepository
{
    IEnumerable<TourBooking> GetTourBookings();
    TourBooking GetTourBookingById(int TourBooking_Id);
    void InsertTourBooking(TourBooking tourbooking);
    void DeleteTourBooking(int TourBooking_Id);
    void UpdateTourBooking(TourBooking tourbooking);
}
