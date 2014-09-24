using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KSAEvenementiel.Controllers
{
    public class ProductionController : Controller
    {
        //
        // GET: /Production/

        /* public ActionResult Index()
        {
            return View();
        }*/

        //
        // GET: /Production/Artistique

        public ActionResult Artistique()
        {
            return View();
        }

        //
        // GET: /Production/Soutien

        public ActionResult Soutien()
        {
            return View();
        }

        //
        // GET: /Production/Formation

        public ActionResult Formation()
        {
            return View();
        }
    }
}
