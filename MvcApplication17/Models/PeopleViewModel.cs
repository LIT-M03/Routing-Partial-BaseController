using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication17.Controllers;

namespace MvcApplication17.Models
{
    public class PeopleViewModel : BaseViewModel
    {
        public IEnumerable<Person> People { get; set; } 
    }
}