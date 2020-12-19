using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BIPIT_9.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        бипит3Entities1 db = new бипит3Entities1();

        public ActionResult Oboryd()
        {
            IEnumerable<Oboryds> oboryd = db.Oboryds;
            ViewBag.Oboryds = oboryd;
            return View("oboryd");
        }

        public ActionResult Vid_rabot()
        {
            IEnumerable<Vid_rabot> vid_rabot = db.Vid_rabot;
            ViewBag.Vid_rabot = vid_rabot;
            return View("vid_rabot");
        }

        public ActionResult Rabot()
        {
            IEnumerable<Rabors> rabot = db.Rabors;
            ViewBag.Rabot = rabot;
            return View("rabot");
        }
    }
}