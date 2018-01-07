using WebASCATUR.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebASCATUR.Data.Interfaces
{
    public interface IServicioRepository
    {
        //IEnumerable<Servicio> servicios { get; }
        IEnumerable<Servicio> aleatorioServicios { get; }
        //Servicio GetDrinkById(int servicioId);
    }
}
