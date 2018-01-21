using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebASCATUR.Data.Models;

namespace WebASCATUR.ViewModels
{
    public class HomeViewModel
    {
        //public RandomProductosViewModel RandomProductos { get; set; }
        //public RandomOpinionesViewModel RandomOpiniones { get; set; }
        //public RandomServiciosViewModel RandomServicios { get; set; }
        //public RandomEventosViewModel RandomEventos { get; set; }
        //public RandomOfertasViewModel RandomOfertas { get; set; }

        //public HomeViewModel()
        //{
            public IEnumerable<Servicio> aleatorioServicios { get; set; }
            public IEnumerable<Opinion> aleatorioOpiniones { get; set; }
            public IEnumerable<Eventos> aleatorioEventos{ get; set; }
            public IEnumerable<Producto> aleatorioProductos { get; set; }
            public IEnumerable<Oferta> aleatorioOfertas { get; set; }
        //RandomProductos = new RandomProductosViewModel();
        //RandomOpiniones = new RandomOpinionesViewModel();
        //RandomServicios = new RandomServiciosViewModel();
        //RandomEventos = new RandomEventosViewModel();
        //RandomOfertas = new RandomOfertasViewModel();

        //}

    }
}
