using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneApplication.Models;

namespace PhoneApplication.Controllers
{
    public class PhoneController : Controller
    {
        // Variables
        List<Phone> phoneList = new List<Phone> { new Phone(01, "iPhone", "Apple", "$5,000", "6 Inches", DateTime.Now),
                new Phone(02, "Android", "Google", "$2,000", "7 Inches", DateTime.Now),
                new Phone(03, "WindowsPhone", "Microsoft", "$3,500", "7 Inches", DateTime.Now)};
        // GET: Phone
        public ActionResult Index()
        {
            return View(phoneList);
        }
    }
}