using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Animal.Models;
using Animal.Models.ViewModel;
using Animal.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Animal.Controllers
{
    public class LrpController : Controller
    {
        private readonly IUserRepository _user;
        private readonly ILrpUserRepository _lrpUser;
        private readonly IMapper _mapper;

        public LrpController(IUserRepository user, ILrpUserRepository lrp, IMapper mapper)
        {
            _user = user;
            _lrpUser = lrp;
            _mapper = mapper;
        }
        // GET: Lrp/Create
        public ActionResult Create()
        {
            LrpVM lrp = new LrpVM();
            return View(lrp);
        }

        // POST: Lrp/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LrpVM lrpUser)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Lrp lrp = _mapper.Map<Lrp>(lrpUser);
                    _lrpUser.Insert(lrp);

                    User user = _mapper.Map<User>(lrpUser);
                    user.Name = lrpUser.fullName;
                    _user.Register(user, lrpUser.password);

                    ViewBag.Message = "Lrp User Created Successfully";
                    return View();
                }
                else
                {
                    ModelState
                        .AddModelError(string.Empty, "Error");
                    return View(lrpUser);

                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.ToString());
                return View();
            }
        }

        // GET: Lrp
        public ActionResult Index()
        {
            return View();
        }

        // GET: Lrp/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

       
        // GET: Lrp/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Lrp/Edit/5
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

        // GET: Lrp/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Lrp/Delete/5
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