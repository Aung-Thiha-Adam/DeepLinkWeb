using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeepLinkWeb.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            var users = new List<User>();
            users.Add(new DeepLinkWeb.User() { Id = 1, Name = "John", Gender = "Male" });
            users.Add(new DeepLinkWeb.User() { Id = 2, Name = "Suzie", Gender = "Female" });

            return View(users);
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            var user = new User();
            if (id == 1)
                user = new User() { Id = 1, Name = "John", Gender = "Male" };
            else if (id == 2)
                user = new User() { Id = 2, Name = "Suzie", Gender = "Female" };
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Users/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}