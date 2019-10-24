using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MouzoAPI.Models
{
    public class Travel
    {
        [Key]
        public int TravelID { get; set; }
        public String Description { get; set; }
        public String TravelDate { get; set; }
        public int Capacity { get; set; }

        public List<Traveler> Travelers { get; set; }
    }
}
