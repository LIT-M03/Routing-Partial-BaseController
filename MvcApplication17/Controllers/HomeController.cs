using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication17.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public void GetSomething(int id)
        {
            Response.Write("<h1>Home#GetSomething Id: " + id + "</h1>");
        }
    }
}
