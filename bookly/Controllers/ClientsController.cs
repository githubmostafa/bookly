using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bookly.Models;

namespace bookly.Controllers
{
    public class ClientsController : Controller
    {
        private DBContext DB;

        public ClientsController()
        {
            DB = new DBContext();
        }

        // GET: Clients
        public ActionResult Index()
        {
            var clients = DB.clients.ToList();
            return View(clients);
        }
    }
}