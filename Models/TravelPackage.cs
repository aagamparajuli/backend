using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace wandermate_backend.Models
{
    [Table("TravelPackage")]
    public class TravelPackage
    {
        [Key]

        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;

        public decimal Price { get; set; }

        public List<string> Image { get; set; } = new List<string>();

    }
}