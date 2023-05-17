using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDeskNST.BussinessObject.Models;

namespace BussinessObject.Models
{
    public class Request
    {

        public int RequestId { get; set; }
        public string Starting { get; set; }
        public string Destination { get; set; } 
        public DateTime TravelDate { get; set; }
        public string Reason { get; set; }
        public int NoOfPerson { get; set; }

        public string Mode { get; set; }

        public User user { get; set; }

    }
}
