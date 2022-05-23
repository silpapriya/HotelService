using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApiService.Models;
using HotelApiService.Repository;

namespace HotelApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        public IActionResult Get()
        {
            List<Hotel> hotels = HotelRepository.GetHotels();


            return Ok(hotels);
           
        }
         public IActionResult Get(int id)
        {

            var hotel = hotels.SingleOrDefault(x => x.HotelId == id);
            if (hotel == null)
            {
                return NotFound("No hotel Found");
            }
            return Ok(hotel);
        }
        [HttpPost]
        public IActionResult Addhotel(Hotel hotel)
        {
            hotels.Add(hotel);
            if (hotels.Count == 0)
            {
                return NotFound("No List Found");
            }
            return Ok(hotels);
        }
        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var hotel = hotels.SingleOrDefault(x => x.HotelId == id);
            if (hotel == null)
            {
                return NotFound("No hotel Found");
            }
            hotels.Remove(hotel);
            if (hotels.Count == 0)
            {
                return NotFound("No List Found");
            }
            return Ok(hotels);
        }
    }
}
