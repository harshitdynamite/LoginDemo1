using LoginDemo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginDemo.Controllers
{
    public class IdentityController : Controller
    {
        private readonly IIdentityService _identityService;
        public IdentityController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        //[HttpGet("api/identity/login")]
        //public IActionResult Login()
        //{
        //    return Ok(new { name = "Harhsit" });
        //}

        //[HttpPost("api/identity/register")]
        //public IActionResult Register()
        //{ 

        //}
    }
}
