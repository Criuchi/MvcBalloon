using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBalloon.Models
{
    public class BalloonSizeViewModel
    {
        public List<Balloon> Balloons { get; set; }
        public SelectList Size { get; set; }
        public string BalloonSize { get; set; }
        public string SearchString { get; set; }
    }
}
