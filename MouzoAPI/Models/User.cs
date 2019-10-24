using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MouzoAPI.Models
{
    public class User
    {
        [Key]
        public String UserID { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Token { get; set; }
        public String Firstname { get; set; }
        public String Lastname { get; set; }

        public List<Traveler> Travelers { get; set; }


    }
}
