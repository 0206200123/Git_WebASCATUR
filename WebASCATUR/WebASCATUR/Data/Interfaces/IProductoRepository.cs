using WebASCATUR.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebASCATUR.Data.Interfaces
{
    public interface IProductoRepository
    {
        //IEnumerable<Producto> productos { get; }
        IEnumerable<Producto> aleatorioProductos { get; }
        //Servicio GetDrinkById(int ProductoId);
    }
}
