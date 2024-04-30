using Learnify.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learnify.Controllers
{
    public class AdminController : Controller
    {
        private readonly LearnifyEntities db = new LearnifyEntities();
        // GET: Admin
        public ActionResult Admin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Admin(string username, string password)
        {
            // Verificar las credenciales
            if (username == "admin" && password == "admin")
            {
                // Si las credenciales son correctas, redirigir a la vista de cursos
                return RedirectToAction("Cursos", "Cursos");
            }
            else
            {
                // Si las credenciales son incorrectas, volver a mostrar la página de inicio de sesión con un mensaje de error
                ViewBag.ErrorMessage = "Nombre de usuario o contraseña incorrectos.";
                return View("InicioSesion");
            }
        }
        public ActionResult ModificarCurso()
        {
            
            return View();
        }
        
    }
}