using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KSAEvenementiel.Controllers
{
    public class ServiceController : Controller
    {
        //
        // GET: /Service/

        /* public ActionResult Index()
        {
            return View();
        } */

        //
        // GET: /Service/Billetterie

        public ActionResult Billetterie()
        {
            return View();
        }

        //
        // GET: /Service/Bureau

        public ActionResult Bureau()
        {
            return View();
        }

        //
        // GET: /Service/Evenement

        public ActionResult Evenement()
        {
            return View();
        }


        //
        // GET: /Service/Materiel

        public ActionResult Materiel()
        {
            return View();
        }

        //
        // GET: /Service/Salle

        public ActionResult Salle()
        {
            return View();
        }

        //
        // GET: /Service/Vente

        public ActionResult Vente()
        {
            return View();
        }
    }
}
