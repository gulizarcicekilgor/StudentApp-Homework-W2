// FakeUserController.cs
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FakeUserController : ControllerBase
    {
        private readonly IFakeUserService _fakeuserService;

        public FakeUserController(IFakeUserService fakeuserService)
        {
            _fakeuserService = fakeuserService;
        }

       

        [HttpPost("login")]
        
        public IActionResult Login([FromBody] FakeUser credentials)
        {
          if (credentials == null || string.IsNullOrWhiteSpace(credentials.UserName) || string.IsNullOrWhiteSpace(credentials.Password))
        {
            return BadRequest("Kullanıcı adı ve şifre gereklidir.");
        }

        IActionResult result = _fakeuserService.LoginFakeUser(credentials.UserName, credentials.Password);

        return result;
        }
    }
}

        


