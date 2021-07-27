﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Catalog.Areas.Catalog.ViewModels
{
    public class BrandForm
    {
        public BrandForm()
        {
            IsPublished = true;
        }

        [Required(ErrorMessage = "The {0} field is required.")]
        public string Slug { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public string Name { get; set; }

        public bool IsPublished { get; set; }
    }
}