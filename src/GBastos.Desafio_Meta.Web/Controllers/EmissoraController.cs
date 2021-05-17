using GBastos.Desafio_Meta.ApplicationCore;
using GBastos.Desafio_Meta.ApplicationCore.Models;
using GBastos.Desafio_Meta.InfraEstructure.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace GBastos.Desafio_Meta.Web.Controllers
{
    public class EmissoraController : System.Web.Mvc.Controller
    {
        private readonly UnitOfWork uwk;

        public EmissoraController()
        {
            uwk = new UnitOfWork();
        }

        public EmissoraController(UnitOfWork unitOfWork)
        {
            uwk = unitOfWork;
        }

        ////
        //// GET: /Emissora/
        //public IActionResult Index()
        //{
        //    List<Emissora> emissora = uwk.EmissoraRep.GetAll().ToList();
        //    return View(emissora);
        //}


        //// GET: Usuario/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Emissora emissora = uwk.EmissoraRep.GetById(id); //db.Usuarios.Find(id);
        //    if (emissora == null)
        //    {
        //        return HttpNotFoundResult();
        //    }
        //    return View(emissora);
        //}


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id, Nome")] Emissora emissora)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            uwk.EmissoraRep.Add(emissora);
        //            return RedirectToAction("Index");
        //        }
        //    }
        //    catch (DataException /* dex */)
        //    {
        //        //Log the error (uncomment dex variable name after DataException and add a line here to write a log.)
        //        ModelState.AddModelError("", "Não foi possível procedercom esta aleração. Se o problema persisir, contate o administrador.");
        //    }

        //    return View(emissora);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(
        //     [Bind(Include = "CourseID,Title,Credits,DepartmentID")] Emissora emissora)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            uwk.CourseRepository.Update(course);
        //            uwk.Save();
        //            return RedirectToAction("Index");
        //        }
        //    }
        //    catch (DataException /* dex */)
        //    {
        //        //Log the error (uncomment dex variable name after DataException and add a line here to write a log.)
        //        ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
        //    }
        //    PopulateDepartmentsDropDownList(course.DepartmentID);
        //    return View(course);
        //}

        //private void PopulateDepartmentsDropDownList(object selectedDepartment = null)
        //{
        //    var departmentsQuery = unitOfWork.DepartmentRepository.Get(
        //        orderBy: q => q.OrderBy(d => d.Name));
        //    ViewBag.DepartmentID = new SelectList(departmentsQuery, "DepartmentID", "Name", selectedDepartment);
        //}

    }
}
