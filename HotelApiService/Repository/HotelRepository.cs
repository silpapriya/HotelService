using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  HotelApiService.Models;
namespace HotelApiService.Repository
{
    public class HotelRepository
    {
        public static List<Hotel> GetHotels()
        {
            var hotelList = new List<Hotel>() {
                new Hotel(){HotelId=100,  HotelName="ABC",  HotelAddress="Pippari Chichwad, Pune", City="Pune", State="Maharashtra", PinCode="411000", IsActive="Available" },
                 new Hotel(){HotelId=101,  HotelName="PQR",  HotelAddress="Mumbai Bandra", City="Mumbai", State="Maharashtra", PinCode="411222", IsActive="Available" },
                  new Hotel(){HotelId=100,  HotelName="XYZ",  HotelAddress="Nampalli Hydrabad", City="Hydrabad", State="Maharashtra", PinCode="411333", IsActive="Available" }

            };

            return hotelList;
        }
    }
}
