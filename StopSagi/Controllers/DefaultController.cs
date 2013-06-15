using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StopSagi.Models;

namespace StopSagi.Controllers
{
    public class DefaultController : Controller
    {
        //
        // GET: /Default/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enemy()
        {
            return View();
        }
        public ActionResult Address()
        {
            var entities = new stopsagiEntities();
            return View(entities.blackList.ToList());
        }
        public ActionResult Consultant()
        {
            return View();
        }
        public ActionResult Prevention()
        {
            return View();
        }


    }
}
