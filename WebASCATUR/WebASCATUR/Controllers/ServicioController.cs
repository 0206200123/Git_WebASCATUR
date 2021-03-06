﻿using System;
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
    public class ServicioController : Controller
    {

        private readonly IServicioRepository _servicioRepository;


        public ServicioController(IServicioRepository servicioRepository)
        {
            _servicioRepository = servicioRepository;

        }

        public ViewResult List(string category)
        {
            
            IEnumerable<Servicio> servicios;
           
            servicios = _servicioRepository.servicios.OrderBy(p => p.Id);
           

            return View(new ServiciosListViewModel
            {
                Servicios = servicios,
                //CurrentCategory = currentCategory
            });
        }

        public ViewResult Detalle(int Id)
        {
            var servicio = _servicioRepository.servicios.FirstOrDefault(d => d.Id == Id);
            if (servicio == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(servicio);
        }

        public ViewResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Servicio> servicios;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                servicios = _servicioRepository.servicios.OrderBy(p => p.Id);
            }
            else
            {
                servicios = _servicioRepository.servicios.Where(p => p.Nombre.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Servicio/List.cshtml", new ServiciosListViewModel { Servicios = servicios });
        }
        // GET: Servicio
        public ActionResult Index()
        {
            return View();
        }

        // GET: Servicio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Servicio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Servicio/Create
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

        // GET: Servicio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Servicio/Edit/5
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

        // GET: Servicio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Servicio/Delete/5
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