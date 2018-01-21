using WebASCATUR.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebASCATUR.Data.Interfaces
{
    public interface IOfertaRepository
    {
        IEnumerable<Oferta> ofertas { get; }
        IEnumerable<Oferta> aleatorioOfertas { get; }
        //Servicio GetDrinkById(int ofertaId);
    }
}
