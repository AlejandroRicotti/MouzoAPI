using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MouzoAPI.Models
{
    public class User
    {
        public String UserID { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Token { get; set; }
        public String Firstname { get; set; }
        public String Lastname { get; set; }

        public List<Traveler> Travelers { get; set; }


    }
}
