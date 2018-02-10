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
    public class ProductoController : Controller
    {

        private readonly IProductoRepository _productoRepository;
        

        public ProductoController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
           
        }

        public ViewResult List(string category)
        {
            //string _category = category;
            IEnumerable<Producto> productos;
            string currentCategory = string.Empty;

            //if (string.IsNullOrEmpty(category))
            //{
                productos = _productoRepository.productos.OrderBy(p => p.Id);
                //currentCategory = "All drinks";
            //}
            //else
            //{
            //    if (string.Equals("Alcoholic", _category, StringComparison.OrdinalIgnoreCase))
            //        drinks = _drinkRepository.Drinks.Where(p => p.Category.CategoryName.Equals("Alcoholic")).OrderBy(p => p.Name);
            //    else
            //        drinks = _drinkRepository.Drinks.Where(p => p.Category.CategoryName.Equals("Non-alcoholic")).OrderBy(p => p.Name);

            //    currentCategory = _category;
            //}

            return View(new ProductosListViewModel
            {
                Productos = productos,
                //CurrentCategory = currentCategory
            });
        }

        public ViewResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Producto> productos;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                productos = _productoRepository.productos.OrderBy(p => p.Id);
            }
            else
            {
                productos = _productoRepository.productos.Where(p => p.Nombre.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Producto/List.cshtml", new ProductosListViewModel { Productos = productos});
        }

        public ViewResult Detalle(int Id)
        {
            var producto = _productoRepository.productos.FirstOrDefault(d => d.Id == Id);
            if (producto == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(producto);
        }

        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Producto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Producto/Create
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

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Producto/Edit/5
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

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Producto/Delete/5
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