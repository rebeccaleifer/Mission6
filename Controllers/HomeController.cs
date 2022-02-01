using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        private MakeAppointmentContext aptContext { get; set; }
        public HomeController(MakeAppointmentContext someName)
        {
            aptContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        public IActionResult ViewAppointments()
        {
            return View();
        }
    }
}
