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
    }
}
