using GameSureWebApp.Areas.Identity.Data;
using GameSureWebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using GameSureWebApp.Models.ViewModels;

namespace GameSureWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<GameSureWebAppUser> _signInManager;


        public HomeController(ILogger<HomeController> logger,SignInManager<GameSureWebAppUser> signInManager )
        {
            _logger = logger;
            _signInManager = signInManager;

        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //public IActionResult UserForm()
        //{
        //    if (_signInManager.IsSignedIn(User))
        //    {
        //        return View();
        //    }
        //    else
        //        return RedirectToAction("Login","Account");
        //}
        
        public IActionResult UserForm()
        {

            return View();
        }
        public IActionResult UserPreview(UserForm userForm)
        {
            if (ModelState.IsValid)
            {
                return View(userForm);
            }
            else
            {
                return View("UserForm", userForm);
            }
        }
        public IActionResult Product()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    
}
