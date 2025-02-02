﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameSureWebApp.Areas.Identity.Data;
using GameSureWebApp.Models;
using GameSureWebApp.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using GameSureWebApp.Controllers;

namespace GameSureWebApp.Controllers
{
    public class UserDetController : Controller
    {
        private readonly SignInManager<GameSureWebAppUser> _signInManager;

        public UserDetController(SignInManager<GameSureWebAppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        // GET: UserDetController
        public ActionResult Index()
        {
            return View();
        }

        
        // GET: UserDetController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserDetController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserDetController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        //public ActionResult UserPreview(UserForm userForm)
        //{
        //    if (_signInManager.IsSignedIn(User))
        //    {
        //        return View(userForm);
        //    }
        //    else
        //        return RedirectToAction("Login","Account");
        //}
        public IActionResult UserPreview(UserForm userForm)
        {
            if(ModelState.IsValid)
            {
                return View(userForm);
            }
            else
            {
                return RedirectToAction("UserForm","Home",userForm);
            }
           
        }
        // GET: UserDetController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserDetController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserDetController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserDetController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
