using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelDeskNST.BussinessObject.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        public DateTime DateOfJoining { get; set; }

        public Boolean IsActive { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime ? DateUpdated { get; set; }

        public Role Role { get; set; }  
       
    }
}
