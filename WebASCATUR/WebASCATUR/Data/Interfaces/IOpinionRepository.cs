using System;
using WebASCATUR.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebASCATUR.Data.Interfaces
{
    public interface IOpinionRepository
    {
        //IEnumerable<Opinion> Opiniones { get; }
        IEnumerable<Opinion> aleatorioOpiniones { get; }
        //Opinion GetDrinkById(int OpinionId);
    }
}
