using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MouzoAPI.Models;
using System.Data.Entity;

namespace MouzoAPI.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection") { }

        public DbSet<User> Countries { get; set; }
        public DbSet<Travel> States { get; set; }
        public DbSet<Traveler> Cities { get; set; }
    }
}
