using Learnify.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learnify.Controllers
{
    public class PagoController : Controller
    {
        private readonly LearnifyEntities db = new LearnifyEntities();
        // GET: Pago
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pago()
        {

            return View();

        }

    }
}