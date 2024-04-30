using Learnify.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace Learnify.Controllers
{
    public class InicioController : Controller
    {
        private readonly LearnifyEntities db = new LearnifyEntities();
        // GET: Inicio
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Inicio()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Inicio(string username, string password)
        {
            var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                return RedirectToAction("Pago", "Pago");
            }
            else
            {
                ViewBag.Message = "Credenciales inválidas.";
            }

            return View();
        }





    }
}