﻿using GameSureWebApp.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameSureWebApp.Models;
using GameSureWebApp.Areas.Identity.Data;

namespace GameSureWebApp.Controllers
{
    public class SaveUserData : Controller
    {
        // GET: SaveUserData
        public ActionResult Index()
        {
            return View();
        }

        // GET: SaveUserData/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SaveUserData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SaveUserData/Create
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
        public ActionResult SaveData(UserForm userForm)
        {
            return View(userForm);
        }

        // GET: SaveUserData/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SaveUserData/Edit/5
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

        // GET: SaveUserData/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SaveUserData/Delete/5
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
