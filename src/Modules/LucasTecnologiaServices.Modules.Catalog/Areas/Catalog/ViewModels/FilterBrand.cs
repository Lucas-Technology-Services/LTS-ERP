﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Catalog.Areas.Catalog.ViewModels
{
    public class FilterBrand
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public int Count { get; set; }
    }
}