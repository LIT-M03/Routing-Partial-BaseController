using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication17.Controllers
{
    public class FooController : Controller
    {
        public void Index()
        {
            Response.Write("<h1>Foo#Index</h1>");
        }

    }
}
