using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebASCATUR.Data.Models;
using WebASCATUR.Data.Interfaces;

namespace WebASCATUR.Data.Repositories
{
    public class OfertaRepository : IOfertaRepository
    {
        private readonly AdmWebASCATUR_Default_v1Context _appDbContext;

        public OfertaRepository(AdmWebASCATUR_Default_v1Context appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //public IEnumerable<Servicio> Drinks => _appDbContext.Servicio.Include(c => c.Category);

        public IEnumerable<Oferta> aleatorioOfertas => _appDbContext.Oferta.OrderBy(x => Guid.NewGuid()).Take(3);

        //public Servicio GetDrinkById(int drinkId) => _appDbContext.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
    }
}
