using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using bookly.Models;
using System.Web.Mvc;

namespace bookly.Controllers
{
    public class BooksController : Controller
    {
        private DBContext DB;
        public BooksController()
        {
            DB = new DBContext();
        }
        protected override void Dispose(bool disposing)
        {
            DB.Dispose();
        }

        // GET: Books
        public ActionResult Index()
        {
            var books = DB.Books.ToList();
            return View(books);
        }
    }
}