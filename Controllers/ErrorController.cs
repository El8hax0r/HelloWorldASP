using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelloWorld.Models;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class ErrorController
    {
        public ActionResult Error()
        {
            return View();
        }
    }
}