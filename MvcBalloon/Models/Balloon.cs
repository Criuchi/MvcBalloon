﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcBalloon.Models
{
    public class Balloon
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // [DataType(DataType.Date)]
        public string Color { get; set; }
        //public DateTime ReleaseDate { get; set; }
        public string Size { get; set; }
        public string Theme { get; set; }
        public decimal Price { get; set; }

    }
}
