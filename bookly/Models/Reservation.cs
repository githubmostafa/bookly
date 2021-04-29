using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace bookly.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public virtual client Client { get; set; }

        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public virtual book Book { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}