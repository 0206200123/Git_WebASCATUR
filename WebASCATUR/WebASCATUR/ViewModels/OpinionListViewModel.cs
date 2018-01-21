using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebASCATUR.Data.Models;

namespace WebASCATUR.ViewModels
{
    public class OpinionListViewModel
    {
        public string Message { get; set; }
        public IEnumerable<Opinion> Opiniones { get; set; }
    }
}
