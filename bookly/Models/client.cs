using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookly.Models
{
    public class client
    {
        public int ClientId { get; set; }
        public String ClientName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String type { get; set; }

    }
}