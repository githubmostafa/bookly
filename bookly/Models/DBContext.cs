using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookly.Models
{
    public class DBContext: DbContext
    {
        
        public DBContext()
        {

        }
        public DbSet<book> Books { get; set; }

        public DbSet<client> clients { get; set; }

        public DbSet<Reservation> reservations { get; set; }

    }

  




}