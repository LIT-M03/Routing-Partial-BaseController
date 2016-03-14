using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttributeRouting;
using AttributeRouting.Web.Mvc;

namespace MvcApplication17.Controllers
{
    [RoutePrefix("a")]
    public class AnswersController : Controller
    {
        [Route("show")]
        public void Show()
        {
            Response.Write("<h1>Answers#Show</h1>");
        }

        [Route("{id}")]
        public void Index(int id)
        {
            Response.Write("<h1>Answer#Index Id: " + id + "</h1>");
        }
    }
}
