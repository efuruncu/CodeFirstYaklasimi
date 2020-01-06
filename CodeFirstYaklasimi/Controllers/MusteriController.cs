using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstYaklasimi.Models;

namespace CodeFirstYaklasimi.Controllers
{
    public class MusteriController : Controller
    {
        SatisContext satisContext = new SatisContext();
        // GET: Musteri
        public ActionResult Index()
        {

            return View(satisContext.Musteri.ToList());
        }
    }
}