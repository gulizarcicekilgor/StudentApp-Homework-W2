// FakeUserService.cs
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Services
{
    public class FakeUserService : IFakeUserService
    {
        private readonly List<FakeUser> FakeUserList;

        public FakeUserService()
        {
            // Öğrenci listesini başlat
            FakeUserList = new List<FakeUser>
        {
            new FakeUser { UserName = "Gülizar", Password = "Gülizar" },
            new FakeUser { UserName = "245", Password = "İsmail" },

        };
        }



        public IActionResult LoginFakeUser(string username, string password)
        {
           // Kullanıcı adı ve şifre kontrolü
            FakeUser user = FakeUserList.FirstOrDefault(u => u.UserName == username && u.Password == password);

            if (user != null)
            {
                return new OkObjectResult("Giriş başarılı"); // 200 OK
            }
            else
            {
                 return new UnauthorizedResult(); // 401 Unauthorized
            }
        }

    }

}
