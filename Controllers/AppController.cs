﻿using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.Controllers
{
    public class AppController: Controller
    {
        public IActionResult Index()
        {
            //throw new InvalidOperationException();
            return View();
        }
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";
            return View();
        }
        [HttpPost("contact")]
        public IActionResult Contact( ContactViewModel model)
        {
            
                return View();
        }
        public IActionResult About()
        {
            ViewBag.Title = "About";
            return View();

        }
    }
}
