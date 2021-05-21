using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Service;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        IUserService UserService { get; }
        public UserController(IUserService userService)
        {
            UserService = userService;
        }

        // GET: UserController
        public ActionResult Index()
        {
            List<User> Model = UserService.users;
            return View(Model);
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            User result = UserService.users.FirstOrDefault(x => x.Id == id);
            
            return View(result);
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                int a = -1;
                if (UserService.users.Any())
                {
                    a = UserService.users.Max(x => x.Id);

                }

                a += 1;

                model.Id = a;

                UserService.users.Add(model);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            User result = UserService.users.FirstOrDefault(x => x.Id == id);


            return View(result);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User model)
        {
            try
            {
                User result = UserService.users.FirstOrDefault(x => x.Id == model.Id);
         
                result.f_name = model.f_name;
                result.l_name = model.l_name;
                result.patronymic = model.patronymic;
                result.birthday = model.birthday;
                result.gender = model.gender;
                result.height = model.height;
                result.weight = model.weight;
                result.isStudent = model.isStudent;
                result.email = model.email;
                result.country = model.country;

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            User result = UserService.users.FirstOrDefault(x => x.Id == id);
            

            return View(result);
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                User result = UserService.users.FirstOrDefault(x => x.Id == id);
                UserService.users.Remove(result);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
