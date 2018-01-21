using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebASCATUR.Data.Models;

namespace WebASCATUR.ViewModels
{
    public class RandomEventosViewModel
    {
        public IEnumerable<Eventos> Eventos { get; set; }
    }
}
