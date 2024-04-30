using Learnify.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learnify.Controllers
{
    public class NuevaCuentaController : Controller
    {
        private readonly LearnifyEntities db = new LearnifyEntities();
        // GET: NuevaCuenta
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NuevaCuenta()
        {
            return View();
        }


        [HttpPost]
        public ActionResult NuevaCuenta(string nombre, string correo, string usuario, string contrasena)
        {
            // Ejecutar el procedimiento almacenado para insertar el nuevo usuario
            var result = db.Database.ExecuteSqlCommand("EXEC InsertarUsuario @Username, @Password",
                new SqlParameter("@Username", usuario),
                new SqlParameter("@Password", contrasena));

            // Verificar el resultado del procedimiento almacenado
            if (result != 1)
            {
                // Si el procedimiento almacenado no se ejecuta correctamente, mostrar un mensaje de error
                ViewBag.ErrorMessage = "Error al crear la cuenta. Por favor, inténtalo de nuevo.";
                return View("NuevaCuenta");
            }

            // Redirigir al usuario a una página de inicio de sesión u otra página de tu aplicación
            return RedirectToAction("Inicio", "Inicio");
        }



    }
}