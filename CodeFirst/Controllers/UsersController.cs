using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CodeFirst.Data.Repository;
using CodeFirst.Library.Interfaces;
using CodeFirst.Models;

namespace CodeFirst.Controllers
{
    public class UsersController : Controller
    {

        private readonly IUsersRepository _repository;

        public UsersController(IUsersRepository repository)
        {
            _repository = repository;
        }

        // GET: Users
        public ActionResult Index()
        {

            var userList = _repository.GetAllUsers();

            var viewModel = new List<UsersViewModel>();

            foreach (var user in userList)
            {
                viewModel.Add(new UsersViewModel()
                {
                    UserId = user.UserId,
                    UserFn = user.UserFn,
                    UserLn = user.UserLn
                });
            }

            return View(viewModel);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            var viewModel = new Models.UsersViewModel();
            return View(viewModel);
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.UsersViewModel user)
        {
            try
            {
                var createdUser = _repository.CreateUser(user.UserFn, user.UserLn);

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