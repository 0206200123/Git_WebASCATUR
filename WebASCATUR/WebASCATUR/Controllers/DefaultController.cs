using WebASCATUR.Data;
using WebASCATUR.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebASCATUR.Data.Interfaces;

namespace WebASCATUR.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IServicioRepository _servicioRepository;
        private readonly IOpinionRepository _opinionRepository;
        private readonly IEventoRepository _eventoRepository;
        private readonly IProductoRepository _productoRepository;
        private readonly IOfertaRepository _ofertaRepository;


        public DefaultController(IServicioRepository servicioRepository, IOpinionRepository opinionRepository, 
                               IEventoRepository eventoRepository, IProductoRepository productoRepository, IOfertaRepository ofertaRepository)
        {
            _servicioRepository = servicioRepository;
            _opinionRepository = opinionRepository;
            _eventoRepository = eventoRepository;
            _productoRepository = productoRepository;
            _ofertaRepository = ofertaRepository;
        }
        // GET: Default
        public ViewResult Index()
        {
            //var homeViewModel = new HomeViewModel;
            //vm.Message = "Hello from DefaultController.Index()";
            //vm.RandomOpiniones.Opiniones = _context.Opinion.ToList();
            //vm.RandomProductos.Productos = _context.Producto.ToList();
            //vm.RandomServicios.Servicios = _context.Servicio.ToList();
            //vm.RandomEventos.Eventos = _context.Eventos.ToList();
            //vm.RandomOfertas.Ofertas = _context.Oferta.ToList();

            var homeViewModel = new HomeViewModel
            {
                aleatorioServicios = _servicioRepository.aleatorioServicios,
                aleatorioOpiniones = _opinionRepository.aleatorioOpiniones,
                aleatorioEventos = _eventoRepository.aleatorioEventos,
                aleatorioProductos = _productoRepository.aleatorioProductos,
                aleatorioOfertas = _ofertaRepository.aleatorioOfertas


            };

            return View(homeViewModel);
          
        }

        //// GET: Default/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Default/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Default/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Default/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Default/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Default/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Default/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}