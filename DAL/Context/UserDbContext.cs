using TravelDeskNST.BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;

namespace DAL.Context
{
    internal class UserDbContext : DbContext
    {
        public UserDbContext() 
        { 

        }
        public UserDbContext(DbContextOptions<UserDbContext> options) : base (options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Request> requests { get ; set; }    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=INW-944;initial catalog=TravelDeskNST;integrated security=true;TrustServerCertificate=True");
        }
    }
}
