using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITHealtAPI.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
   
    }
}
