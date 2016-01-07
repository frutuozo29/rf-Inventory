using AutoMapper;
using RF.Inventory.Application.Interfaces;
using RF.Inventory.Domain.Entities;
using RF.Inventory.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace RF.Inventory.MVC.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly IEmpresaAppService _empresaApp;

        public EmpresaController(IEmpresaAppService empresaApp)
        {
            _empresaApp = empresaApp;
        }
        
        // GET: Empresa
        public ActionResult Index()
        {
            var empresaViewModel = Mapper.Map<IEnumerable<Empresa>, IEnumerable<EmpresaViewModel>>(_empresaApp.GetAll());
            return View(empresaViewModel);
        }

        // GET: Empresa/Details/5
        public ActionResult Details(long id)
        {
            var empresaViewModel = Mapper.Map<Empresa, EmpresaViewModel>(_empresaApp.GetById(id));
            return View(empresaViewModel);
        }

        // GET: Empresa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empresa/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmpresaViewModel empresa)
        {
            if (ModelState.IsValid)
            {
                var empresaViewModel = Mapper.Map<EmpresaViewModel, Empresa>(empresa);
                _empresaApp.Add(empresaViewModel);
                return RedirectToAction("Index");
            }
            return View(empresa);
        }

        // GET: Empresa/Edit/5
        public ActionResult Edit(long id)
        {
            var empresaViewModel = Mapper.Map<Empresa, EmpresaViewModel>(_empresaApp.GetById(id));
            return View(empresaViewModel);
        }

        // POST: Empresa/Edit/5
        [HttpPost]
        public ActionResult Edit(EmpresaViewModel empresa)
        {
            if (ModelState.IsValid)
            {
                var empresaViewModel = Mapper.Map<EmpresaViewModel, Empresa>(empresa);
                _empresaApp.Update(empresaViewModel);
                return RedirectToAction("Index");
            }
            return View(empresa);
        }

        // GET: Empresa/Delete/5
        public ActionResult Delete(long id)
        {
            var empresaViewModel = Mapper.Map<Empresa, EmpresaViewModel>(_empresaApp.GetById(id));
            return View(empresaViewModel);
        }

        // POST: Empresa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            var empresa = _empresaApp.GetById(id);
            _empresaApp.Remove(empresa);

            return RedirectToAction("Index");
        }
    }
}
