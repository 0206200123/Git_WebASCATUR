using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebASCATUR.Data.Models;

namespace WebASCATUR.Data.Interfaces
{
    public interface IComercioRepository
    {
        IEnumerable<Comercio> comercios { get; }
        IEnumerable<Comercio> aleatorioComercios { get; }
        //Servicio GetDrinkById(int ProductoId);
    }
}
