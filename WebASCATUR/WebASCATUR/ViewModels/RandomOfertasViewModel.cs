﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebASCATUR.Data.Models;

namespace WebASCATUR.ViewModels
{
    public class RandomOfertasViewModel
    {
        public IEnumerable<Oferta> Ofertas { get; set; }
    }
}