using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PacificTours.Models;

namespace PacificTours.Repository
{
    public class HotelBookingContext : DbContext
    {
        public DbSet<HotelBooking> HotelBookings { get; set; }
    }

    public class HotelBookingRepository : IHotelBookingRepository
    {
        private readonly HotelBookingContext _context;
        public HotelBookingRepository(HotelBookingContext context)
        {
            _context = context;
        }
        public IEnumerable<HotelBooking> GetHotelBookings()
        {
            return _context.HotelBookings;
        }

        public HotelBooking GetHotelBookingById(int Booking_Id)
        {
            return _context.HotelBookings.Find(Booking_Id.ToString());
        }
        public void InsertHotelBooking(HotelBooking hotelbooking)
        {
            _context.HotelBookings.Add(hotelbooking);
        }
        public void DeleteHotelBooking(int Booking_Id)
        {
            HotelBooking hotelbooking = _context.HotelBookings.Find(Booking_Id);
            _context.HotelBookings.Remove(hotelbooking);
        }
        public void UpdateHotelBooking(int Booking_Id)
        {
            _context.Entry(Booking_Id).State = EntityState.Modified;
        }
    }
}