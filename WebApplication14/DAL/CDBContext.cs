using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CDBContext  :DbContext
    {
        public CDBContext() : base("name=newDatabaseContext")
        {
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
     
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Provider> Providers { get; set; }
    }
}
