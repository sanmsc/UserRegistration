using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserRegistration.Models;

namespace UserRegistration.Controllers
{
    public class EmployeeController:Controller
    {

        public ActionResult List()
        {
            var repo = new EmployeeRepository();
            var employee = repo.GetAll();

            return View(employee);


        }
    }
}