using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PacificTours.Models;

namespace PacificTours.Services
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) // Constructor for class
        {

        }
        public DbSet<Hotel> hotels { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            var admin = new IdentityRole("admin");
            admin.NormalizedName = "admin";

            var client = new IdentityRole("client");
            client.NormalizedName = "client";

            var seller = new IdentityRole("seller");
            seller.NormalizedName = "seller";

            builder.Entity<IdentityRole>().HasData(admin, client, seller);

            var hotelList = new List<Hotel>
            {
                new() { Hotel_Id=1, HotelName="Hilton London Hotel", SingleRoomPrice="375", DoubleRoomPrice="775", FamilyRoomPrice="950"},
                new() { Hotel_Id=2, HotelName="London Marriott Hotel", SingleRoomPrice = "300", DoubleRoomPrice = "500", FamilyRoomPrice = "900" },
                new() { Hotel_Id=3, HotelName="Travelodge Brighton Seafront", SingleRoomPrice = "80", DoubleRoomPrice = "120", FamilyRoomPrice = "150" },
                new() { Hotel_Id=4, HotelName="Kings Hotel Brighton", SingleRoomPrice = "180", DoubleRoomPrice = "400", FamilyRoomPrice = "520" },
                new() { Hotel_Id=5, HotelName="Leonardo Hotel Brighton", SingleRoomPrice = "180", DoubleRoomPrice = "400", FamilyRoomPrice = "520" },
                new() { Hotel_Id=6, HotelName="Nevis Bank Inn, Fort William", SingleRoomPrice = "90", DoubleRoomPrice = "100", FamilyRoomPrice = "155" }
            };

            foreach (var hotel in hotelList)
            {
                builder.Entity<Hotel>().HasData(hotel);
            }
            
        }
    }
}
