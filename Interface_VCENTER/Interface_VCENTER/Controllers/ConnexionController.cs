using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interface_VCENTER.Controllers
{
    public class ConnexionController : Controller
    {
        // GET: Connexion
        [HttpGet]
        public ActionResult Login(int? id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login()
        {
            return RedirectToAction("Index", "Home");
        }

    }
}