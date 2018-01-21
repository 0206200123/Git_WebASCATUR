using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebASCATUR.Data.Models;
using WebASCATUR.Data.Interfaces;

namespace WebASCATUR.Data.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly AdmWebASCATUR_Default_v1Context _appDbContext;

        public ProductoRepository(AdmWebASCATUR_Default_v1Context appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Producto> productos => _appDbContext.Producto;

        public IEnumerable<Producto> aleatorioProductos=> _appDbContext.Producto.OrderBy(x => Guid.NewGuid()).Take(3);

        //public Servicio GetDrinkById(int drinkId) => _appDbContext.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
    }
}
