using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcBalloon.Models
{
    public class Balloon
    {
        //Creating every element for the table with it's own validations
        public int Id { get; set; }

        // Name
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        // Color
        [StringLength(60, MinimumLength = 3)]
        public string Color { get; set; }

        // Size
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Size { get; set; }

        // Theme
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Theme { get; set; }

        // Price
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        // Rating
        [Range(1, 5)]
        [Required]
        public int Rating { get; set; }

    }
}
