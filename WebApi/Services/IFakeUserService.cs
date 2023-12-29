// Services/IFakeUserService.cs
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Services
{
    public interface IFakeUserService
    {
         IActionResult LoginFakeUser(string username, string password);
    }
    
}
