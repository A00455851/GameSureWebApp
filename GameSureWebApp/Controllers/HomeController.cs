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
using GameSureWebApp.Data;

namespace GameSureWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<GameSureWebAppUser> _signInManager;
        private readonly GameSureDBContext _gameSureDBContext;


        public HomeController(ILogger<HomeController> logger,SignInManager<GameSureWebAppUser> signInManager, GameSureDBContext gameSureDBContext )
        {
            _logger = logger;
            _signInManager = signInManager;
            _gameSureDBContext = gameSureDBContext;
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

         [HttpGet]
      
        public IActionResult UserForm(UserForm userForm)
        
        {

            return View(userForm);
        }
        [HttpPost]
        public IActionResult UserPreview(UserForm userForm)
        {
            
            //var product1 = _gameSureDBContext.Products.OrderBy(p1=>p1.ProdId);
            

            if (ModelState.IsValid)
            {
               
                return View(userForm);
            }
            else
            {
                foreach (var modelState in ViewData.ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        // Get the Error details.
                    }
                }
                return View("UserForm", userForm);
            }
            
        }

        [AllowAnonymous]
        public IActionResult Product()
        {
            var product1 = (from Product in _gameSureDBContext.Products
                           select Product).ToList();
            
            return View(product1);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    
}
