using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebASCATUR.Data.Models;
using WebASCATUR.Data.Interfaces;

namespace WebASCATUR.Data.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        private readonly AdmWebASCATUR_Default_v1Context _appDbContext;

        public EventoRepository(AdmWebASCATUR_Default_v1Context appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Eventos> eventos => _appDbContext.Eventos;

        public IEnumerable<Eventos> aleatorioEventos => _appDbContext.Eventos.OrderBy(x => Guid.NewGuid()).Take(5);

        //public Servicio GetDrinkById(int drinkId) => _appDbContext.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
    }
}
