using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[AcceptVerbs("POST")]
        //public IActionResult CountResult([FromBody]string value)
        //{
        //    int toReturn = value.Count();
        //    return Json(toReturn);
        //}
    }
}
