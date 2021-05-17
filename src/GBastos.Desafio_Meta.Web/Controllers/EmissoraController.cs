using GBastos.Desafio_Meta.ApplicationCore;
using GBastos.Desafio_Meta.InfraEstructure.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace GBastos.Desafio_Meta.Web.Controllers
{
    public class EmissoraController : Controller
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

        //
        // GET: /Emissora/
        public IActionResult Index()
        {
            List<Emissora> emissora = uwk.EmissoraRep.GetAll().ToList();
            return View(emissora);
        }

        //public ViewResult Index()
        //{
        //    //var emisssoras = uwk.EmissoraRep.GetAll(includeProperties: "Department");
        //    var emisssoras = uwk.EmissoraRep.GetAll();
        //    return View(emisssoras.ToList());
        //}

    }
}
