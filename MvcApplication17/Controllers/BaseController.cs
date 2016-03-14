using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication17.Models;

namespace MvcApplication17.Controllers
{
    public class BaseController : Controller
    {
        protected override ViewResult View(IView view, object model)
        {
            if (model == null)
            {
                model = new BaseViewModel { DateTime = DateTime.Now };
            }
            else
            {
                var bvm = (BaseViewModel)model;
                bvm.DateTime = DateTime.Now;
            }
            return base.View(view, model);
        }

        protected override ViewResult View(string viewName, string masterName, object model)
        {
            if (model == null)
            {
                model = new BaseViewModel { DateTime = DateTime.Now };
            }
            else
            {
                var bvm = (BaseViewModel)model;
                bvm.DateTime = DateTime.Now;
            }
            return base.View(viewName, masterName, model);
        }
    }
}
