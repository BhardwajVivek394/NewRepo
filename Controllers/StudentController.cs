﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentBio()
        {
            return View();
        }
    }
}
