using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PacificTours.Models;

namespace PacificTours.Repository
{
    public class TourBookingContext : DbContext
    {
        public DbSet<TourBooking> TourBookings { get; set; }
    }

    public class TourBookingRepository : ITourBookingRepository
    {
        private readonly TourBookingContext _context;
        public TourBookingRepository(TourBookingContext context)
        {
            _context = context;
        }
        public IEnumerable<TourBooking> GetTourBookings()
        {
            return _context.TourBookings;
        }

        public TourBooking GetTourBookingById(int TourBooking_Id)
        {
            return _context.TourBookings.Find(TourBooking_Id.ToString());
        }
        public void InsertTourBooking(TourBooking tourbooking)
        {
            _context.TourBookings.Add(tourbooking);
        }
        public void DeleteTourBooking(int TourBooking_Id)
        {
            TourBooking tourbooking = _context.TourBookings.Find(TourBooking_Id);
            _context.TourBookings.Remove(tourbooking);
        }
        public void UpdateTourBooking(TourBooking tourbooking)
        {
            _context.Entry(tourbooking).State = EntityState.Modified;
        }
    }
}
