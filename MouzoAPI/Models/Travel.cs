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
        [Required]
        public String Description { get; set; }
        [Required]
        public String TravelDate { get; set; }
        [Required]
        public int Capacity { get; set; }

        public List<Traveler> Travelers { get; set; }
    }
}
