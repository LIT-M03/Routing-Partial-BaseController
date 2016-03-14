using AttributeRouting.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication17.Controllers
{
    public class BlogController : Controller
    {
        [Route("Blog/{slug}")]
        public void Index(string slug)
        {
           Response.Write("<h1>Blog page with slug: " + slug + " </h1>");
        }

        public void Foobar()
        {
            
        }
    }
}
