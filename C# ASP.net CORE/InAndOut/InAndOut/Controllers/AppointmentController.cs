﻿using Microsoft.AspNetCore.Mvc;

namespace InAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int Id)
        {
            return Ok("You have entered id = "+ Id);
        }
    }
}
