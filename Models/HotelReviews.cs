using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace wandermate_backend.Models
{
    public class HotelReviews
    {
        [Key]
        public int ReviewId { get; set; }

        public int Rating { get; set; }
        public string ReviewText { get; set; } = string.Empty;
        public string CreatedOn { get; set; } = string.Empty;

        [ForeignKey("Hotel")]
        public int HotelId { get; set; }

        public Hotel? Hotel { get; set; }
    }

}