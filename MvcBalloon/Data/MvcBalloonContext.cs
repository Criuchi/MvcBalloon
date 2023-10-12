using Microsoft.EntityFrameworkCore;
using MvcBalloon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Creation of the MvcBalloonContext Class

namespace MvcBalloon.Data
{
    public class MvcBalloonContext : DbContext

    {
        public MvcBalloonContext(DbContextOptions<MvcBalloonContext> options)
    : base(options)
        {
        }

        public DbSet<Balloon> Balloon { get; set; }
    }
}
