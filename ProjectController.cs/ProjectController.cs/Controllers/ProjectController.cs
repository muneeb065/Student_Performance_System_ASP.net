using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace razor_syntax.Controllers
{
    public class ProjectController : Controller
    {
        //Get : Project
        public ActionResult LoginForm()
        {
            return View();
        }
    }
}