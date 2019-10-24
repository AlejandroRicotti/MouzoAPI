using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MouzoAPI.Models;

namespace MouzoAPI.Models
{
    public class MouzoAPIContext : DbContext
    {
        public MouzoAPIContext (DbContextOptions<MouzoAPIContext> options)
            : base(options)
        {
        }

        public DbSet<MouzoAPI.Models.Travel> Travel { get; set; }

        public DbSet<MouzoAPI.Models.User> User { get; set; }

        public DbSet<MouzoAPI.Models.Traveler> Traveler { get; set; }
    }
}
