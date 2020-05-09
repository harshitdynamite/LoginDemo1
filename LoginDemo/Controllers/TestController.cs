﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginDemo.Controllers
{
    public class TestController : Controller
    {
        [HttpGet("api/User")]
        public IActionResult Get()
        {
            return Ok(new { name = "Harhsit" });
        }
    }
}
