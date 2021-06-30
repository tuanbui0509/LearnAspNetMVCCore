using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //string today = DateTime.Now.ToShortDateString();

            //return Ok(today);
        }

        public IActionResult Details(int id)
        {
            return Ok("Okie baby nà aaa " + id);
        }
    }
}
