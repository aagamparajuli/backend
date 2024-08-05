using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace wandermate_backend.Models
{
    public class HOtelInfo
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;

        [ForeignKey("Hotels")]
        public int HotelId { get; set; }

        public Hotel? Hotel { get; set; }
    }
}