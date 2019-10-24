using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MouzoAPI.Models
{
    public class Traveler
    {
        [Key]
        public int TravelerID { get; set; }
        [Required]
        public String Firstname { get; set; }
        [Required]
        public String Lastname { get; set; }
        public String DNI { get; set; }
        public String Phone { get; set; }
        public String NumberMember { get; set; }
        public String TypeMember { get; set; }
        public String PeñaMember { get; set; }
        public int Payment { get; set; }
        public int Amount { get; set; }
        public String Description { get; set; }
        public Boolean Deleted { get; set; }
        public String DeletedBy { get; set; }
        public Boolean Queue { get; set; }

        public int TravelID { get; set; }
        public Travel Travel { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

    }
}
