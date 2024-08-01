using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using wandermate_backend.Data;
using wandermate_backend.Models;  


namespace wandermate_backend.Controller
{

    [Route("wandermate_backend/hotel")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
 
        public HotelController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult GetAll() {
            var hotel = _context.Hotel.ToList();
            return Ok(hotel);
        }

        [HttpGet("{id}")]

        public IActionResult GetById([FromRoute] int id) {
            var hotel = _context.Hotel.Find(id);
            if (hotel == null) { 
                return NotFound();
            }
            return Ok(hotel);

        }

        [HttpPost]

        public IActionResult CreateHotel([FromBody] Hotel hotel) {
            if (hotel == null) { 
                return BadRequest();
            }
            _context.Hotel.Add(hotel);
            _context.SaveChanges();
            return Ok(hotel);

        }

        [HttpPut("{id}")]

        public IActionResult UpdateHotel(int id, [FromBody] Hotel hotel ) {
           
            if(hotel == null) {
                return BadRequest();
            }
            var hotelDb= _context.Hotel.Find(id);

            if(hotelDb == null){
                return NotFound();
            }
            hotelDb.Name = hotel.Name;
            hotelDb.Price = hotel.Price;
            hotelDb.Image = hotel.Image;
            hotelDb.Description = hotel.Description;
            _context.Hotel.Update(hotelDb);
            _context.SaveChanges();

            return Ok(hotelDb);
            


           

        }

        



    }
}