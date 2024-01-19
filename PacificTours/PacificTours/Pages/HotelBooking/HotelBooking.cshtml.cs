using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace PacificTours.Pages.HotelBooking
{
    public class HotelBookingModel : PageModel
    {
        public List<HotelBookingInfo> listHotelBooking = new List<HotelBookingInfo>();
        public void OnGet()
        {
            try
            {
                string connectionString = "Data Source=T480\\sqlexpress;Initial Catalog=AuthorisationDB; Integrated Security=True; ; TrustServerCertificate = True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM hotelbooking";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                HotelBookingInfo hotelBooking = new HotelBookingInfo();
                                hotelBooking.id = "" + reader.GetInt32(0);
                                hotelBooking.hotel = reader.GetString(1);
                                hotelBooking.room = reader.GetString(2);
                                hotelBooking.checkindate = reader.GetDateTime(3);
                                hotelBooking.checkoutdate = reader.GetDateTime(4);
                                hotelBooking.created_at = reader.GetDateTime(5);
                                hotelBooking.hotelandroom = hotelBooking.hotel + hotelBooking.room;

                                listHotelBooking.Add(hotelBooking);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problem: " + ex.ToString());
            }
        }
    }
    public class HotelBookingInfo
    {
        public string id;
        public string hotel;
        public string room;
        public string hotelandroom;
        public DateTime checkindate;
        public DateTime checkoutdate;
        public DateTime created_at;
    }
}
