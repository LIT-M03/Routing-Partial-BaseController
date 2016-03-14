using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication17.Models;

namespace MvcApplication17.Controllers
{
    public class PeopleController : BaseController
    {
        private static List<Person> _people = new List<Person>();

        public ActionResult Index()
        {
            return View(new PeopleViewModel { People = _people });
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(Person person)
        {
            person.Id = new Random().Next(1, 1000000);
            _people.Add(person);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            return View(
                new PersonViewModel { Person = _people.First(p => p.Id == id) });
        }

        [HttpPost]
        public ActionResult Edit(Person person)
        {
            var theGuy = _people.First(p => p.Id == person.Id);
            theGuy.FirstName = person.FirstName;
            theGuy.LastName = person.LastName;
            theGuy.Age = person.Age;
            return RedirectToAction("Index");
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
    }
}
