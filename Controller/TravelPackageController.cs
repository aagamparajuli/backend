using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using wandermate_backend.Data;


namespace wandermate_backend.Controller
{

    [Route("wandermate_backend/travelPackage")]
    [ApiController]
    public class TravelPackageController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
 
        public TravelPackageController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult GetAll() {
            var travelPackages = _context.TravelPackage.ToList();
            return Ok(travelPackages);
        }

        [HttpGet("{id}")]

        public IActionResult GetById([FromRoute] int id) {
            var travelPackages = _context.TravelPackage.Find(id);
            if (travelPackages == null) { 
                return NotFound();
            }
            return Ok(travelPackages);

        }


    }
}