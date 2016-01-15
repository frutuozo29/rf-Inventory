using RF.Inventory.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RF.Inventory.MVC.Controllers
{
    public class SituacaoDiefController : Controller
    {
        private readonly ISituacaoDiefAppService _situacaoDiefAppService;

        public SituacaoDiefController(ISituacaoDiefAppService situacaoDiefAppService)
        {
            _situacaoDiefAppService = situacaoDiefAppService;
        }

        // GET: SituacaoDief
        public ActionResult Index()
        {
            return View(_situacaoDiefAppService.GetAll().ToList());
        }

        // GET: SituacaoDief/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SituacaoDief/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SituacaoDief/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SituacaoDief/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SituacaoDief/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SituacaoDief/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SituacaoDief/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
