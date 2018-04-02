using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserRegistration.Controllers
{
    public class RedirectController : Controller
    {
        // GET: Redirect
        public ActionResult Index()
        {
            return View();
        }

        //Get All EMPs
        // DO later - Add all methods
        public ActionResult GetAll()
        {
            return View();
        }



    }
}