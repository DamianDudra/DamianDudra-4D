using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
namespace WebApplication3.Controllers
{
    public class UlohyController : Controller
    {
        public IActionResult uloha1()
        {
            return View();
        }
        public IActionResult uloha2()
        {
            return View();
        }
        public IActionResult uloha3()
        {
            return View();
        }
        public IActionResult uloha4()
        {
            var userList = new List<UserInfo>()
            {
                new UserInfo
                {
                    Name="Test",
                    Surname="Test",
                    Email="test@gmail.com",
                },
                new UserInfo
                {
                    Name = "Jozef",
                    Surname="Mrkvička",
                    Email = "jozef@gmail.com",
                } };
            return View(userList);
        }
        public IActionResult uloha5()
        {
            var userList = new List<UserInfo>()
            {
                new UserInfo
                {
                    Name="Test",
                    Surname="Test",
                    Email="test@gmail.com",
                },
                new UserInfo
                {
                    Name = "Jozef",
                    Surname="Mrkvička",
                    Email = "jozef@gmail.com",
                } };
            return View(userList);
        }
        public IActionResult uloha6()
        {
            return View();
        }
        public IActionResult uloha7()
        {
            return View();
        }
        public IActionResult uloha8()
        {
            return View();
        }
        public IActionResult uloha9()
        {
            return View();
        }
        private static List<User> users = new List<User>();

        [HttpGet]
        public IActionResult LoginForm()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult LoginForm(User model)
        {
            var user = new User()
            {
                UserPublicId = Guid.NewGuid(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Age = model.Age,
                Password = model.Password,
                Vlastnosti = model.Vlastnosti
            };
            users.Add(user);
            ViewBag.Users = users;
            return View("Register", user);
        }
    }
}