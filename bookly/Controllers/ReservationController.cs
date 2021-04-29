using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using bookly.Models;
namespace bookly.Controllers
{
    public class ReservationController : Controller
    {
        private DBContext DB;
        public ReservationController()
        {
            DB = new DBContext();
        }
        // GET: Reservation
        public ActionResult Index()
        {
            var reservations = DB.reservations.Include(c => c.Book).Include(c=>c.Client).ToList();

              
            return View(reservations);
        }
        public ActionResult Delete(int Id)
        {
            Reservation rs = DB.reservations.Find(Id);
            DB.reservations.Remove(rs);
            DB.SaveChanges();

            return RedirectToAction("Index");
           

        }
    }
}