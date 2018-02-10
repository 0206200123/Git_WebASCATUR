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

            comercios = _comercioRepository.comercios.OrderBy(p => p.Id);


            return View(new ComercioListViewModel
            {
                Comercios = comercios,
              
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

        public ViewResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Comercio> comercios;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                comercios = _comercioRepository.comercios.OrderBy(p => p.Id);
            }
            else
            {
                comercios = _comercioRepository.comercios.Where(p => p.Nombre.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Comercio/List.cshtml", new ComercioListViewModel { Comercios = comercios });
        }

    }
}