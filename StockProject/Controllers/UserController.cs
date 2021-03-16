using DataModel;
using Logic;
using Microsoft.AspNetCore.Mvc;
using StockProject.Models;
using System;
using Hanssens.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockProject.Controllers
{
    public class UserController : Controller
    {
        private readonly UserLogic logic;
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login(UserViewModel user)
        {
            UserDataModel userlog = new UserDataModel();
            userlog.Username = user.Username;
            userlog.Passsword = user.Password;
            if (logic.CheckUser(userlog))
            {
                var storage = new LocalStorage();
                storage.Store("id", userlog.IdUser);
                storage.Persist();
                return RedirectToAction("index", "Home");
            }

            return View(logic.CheckUser(userlog));
        }

        public IActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterUser(RegisterViewModel user)
        {
            var createuser = new UserDataModel(user.Username, user.Email, user.Password, user.FirstName, user.LastName);
            if(user.Password == user.PasswordRpt)
            {
                return RedirectToAction("index", "home");
            }
            return View();
        }

        public IActionResult List(UserDataModel user)
        {
            if(user != null)
            {
                return View();
            }

            return RedirectToAction("index", "home");   
        }
    }
}
