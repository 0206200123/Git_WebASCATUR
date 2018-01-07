using WebASCATUR.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebASCATUR.Data.Interfaces
{
    public interface IEventoRepository
    {
        //IEnumerable<Evento> eventos { get; }
        IEnumerable<Eventos> aleatorioEventos { get; }
        //Servicio GetDrinkById(int eventoId);
    }
}
