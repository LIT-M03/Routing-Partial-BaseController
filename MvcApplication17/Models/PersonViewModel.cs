using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication17.Controllers;

namespace MvcApplication17.Models
{
    public class PersonViewModel : BaseViewModel
    {
        public Person Person { get; set; }
    }
}