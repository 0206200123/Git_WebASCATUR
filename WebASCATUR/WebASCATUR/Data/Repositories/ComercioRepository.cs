using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebASCATUR.Data.Interfaces;
using WebASCATUR.Data.Models;

namespace WebASCATUR.Data.Repositories
{
    public class ComercioRepository : IComercioRepository
    {
        private readonly AdmWebASCATUR_Default_v1Context _appDbContext;

        public ComercioRepository(AdmWebASCATUR_Default_v1Context appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Comercio> comercios => _appDbContext.Comercio;

        public IEnumerable<Comercio> aleatorioComercios => _appDbContext.Comercio.OrderBy(x => Guid.NewGuid()).Take(5);

        //public Servicio GetDrinkById(int drinkId) => _appDbContext.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
    }
}
