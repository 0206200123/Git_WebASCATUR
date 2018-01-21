using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebASCATUR.Data.Interfaces;
using WebASCATUR.Data.Models;
using WebASCATUR.ViewModels;

namespace WebASCATUR.Controllers
{
    public class OfertaController : Controller
    {

        private readonly IOfertaRepository _ofertaRepository;


        public OfertaController(IOfertaRepository ofertaRepository)
        {
            _ofertaRepository = ofertaRepository;

        }

        public ViewResult List(string category)
        {

            IEnumerable<Oferta> ofertas;

            ofertas = _ofertaRepository.ofertas.OrderBy(p => p.Id);


            return View(new OfertasListViewModel
            {
                Ofertas = ofertas,
                //CurrentCategory = currentCategory
            });
        }

        public ViewResult Detalle(int Id)
        {
            var oferta = _ofertaRepository.ofertas.FirstOrDefault(d => d.Id == Id);
            if (oferta == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(oferta);
        }

        // GET: Oferta
        public ActionResult Index()
        {
            return View();
        }

        // GET: Oferta/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Oferta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Oferta/Create
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

        // GET: Oferta/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Oferta/Edit/5
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

        // GET: Oferta/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Oferta/Delete/5
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