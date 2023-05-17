using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelDeskNST.BussinessObject.Models;

namespace BAL
{
    public class BAL
    {
        DAL.Dal Dal = new DAL.Dal();    
        public int AddUser( User user ) 
        { 
            Dal.AddUser(user); 
            return 0;
        }
        public Role GetRole(string rolename)
        {
            return Dal.GetRole(rolename);
        }
        public User GetUser(string username) 
        {
            return Dal.GetUser(username);
        }
        public int AddRequest(Request request)
        {
            Dal.AddRequest(request);
            return 0;
        }

    }
}
