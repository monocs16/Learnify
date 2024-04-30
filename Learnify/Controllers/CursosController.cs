using Learnify.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learnify.Controllers
{
    public class CursosController : Controller
    {
        private readonly LearnifyEntities db = new LearnifyEntities();
        // GET: Cursos
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cursos()
        {
            var Cursos = db.ObtenerCursos();
            return View(Cursos);
        }
    }
}