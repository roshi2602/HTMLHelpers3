using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTMLHelpers3.Models;
namespace HTMLHelpers3.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult MyEditHelper()
        {
            //create employee object and pass data in it
            Employee ee = new Employee()
            {
                Eid = 1,
                Ename = "paul",
                newEnrollment = true,
                DOB = Convert.ToDateTime("12-07-2021")    //converting string to datetime
            };
            return View(ee);
        }
    }
}