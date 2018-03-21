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
    public class EventoController : Controller
    {

        private readonly IEventoRepository _eventoRepository;


        public EventoController(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;

        }

        public ViewResult List(string category)
        {

            IEnumerable<Eventos> eventos;

            eventos = _eventoRepository.eventos.OrderBy(p => p.Id);


            return View(new EventosListViewModel
            {
                Eventos = eventos,
                //CurrentCategory = currentCategory
            });
        }

        public ViewResult Detalle(int Id)
        {
            var evento = _eventoRepository.eventos.FirstOrDefault(d => d.Id == Id);
            if (evento == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(evento);
        }


        public ViewResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Eventos> eventos;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                eventos = _eventoRepository.eventos.OrderBy(p => p.Id);
            }
            else
            {
                eventos = _eventoRepository.eventos.Where(p => p.Nombre.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Evento/List.cshtml", new EventosListViewModel{ Eventos = eventos });
        }

        // GET: Evento
        public ActionResult Index()
        {
            return View();
        }

        // GET: Evento/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Evento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Evento/Create
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

        // GET: Evento/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Evento/Edit/5
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

        // GET: Evento/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Evento/Delete/5
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