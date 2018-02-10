using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebASCATUR.Data.Interfaces;
using WebASCATUR.Data.Models;
using WebASCATUR.ViewModels;

namespace WebASCATUR.Controllers
{
    public class ComercioController : Controller
    {
        private readonly IComercioRepository _comercioRepository;
        public ComercioController(IComercioRepository comercioRepository)
        {
            _comercioRepository = comercioRepository;

        }

        public ViewResult List(string category)
        {
            //string _category = category;
            IEnumerable<Comercio> comercios;
            string currentCategory = string.Empty;

            //if (string.IsNullOrEmpty(category))
            //{
            comercios = _comercioRepository.comercios.OrderBy(p => p.Id);
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

            return View(new ComercioListViewModel
            {
                Comercios = comercios,
                //CurrentCategory = currentCategory
            });
        }

        public ViewResult Detalle(int Id)
        {
            var comercio = _comercioRepository.comercios.FirstOrDefault(d => d.Id == Id);
            if (comercio == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(comercio);
        }

    }
}