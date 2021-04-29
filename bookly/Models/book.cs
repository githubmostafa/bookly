using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookly.Models
{
    public class book
    {
        public int BookId { get; set; }
        public String name { get; set; }
        public String genre { get; set; }
        public int NumberInStock { get; set; }
    }
}