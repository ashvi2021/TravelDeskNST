using TravelDeskNST.BussinessObject.Models;
using DAL.Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;

namespace DAL
{
    public class Dal
    {

        UserDbContext db = new UserDbContext();
        

        
       
        public int AddUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return 0;
        }
        public Role GetRole(string rolename)
        {
            return (db.Role.FirstOrDefault(x => x.RoleName == rolename));
        }
       
        public User GetUser(string username)
        {
            return db.Users.FirstOrDefault(x => x.FirstName == username);
        }
        public int AddRequest(Request a)
        {
            db.requests.Add(a);
            db.SaveChanges();
            return 0;

            
        }


    }
}
