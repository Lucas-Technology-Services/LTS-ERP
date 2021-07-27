﻿using LucasTecnologiaServices.Modules.Catalog.Models;
using LucasTecnologiaServices.Modules.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Catalog.Areas.Catalog.ViewModels
{
    public class CategoryThumbnail
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public string Description { get; set; }

        public Media ThumbnailImage { get; set; }

        public string ThumbnailUrl { get; set; }

        public static CategoryThumbnail FromCategory(Category category)
        {
            var result = new CategoryThumbnail()
            {
                Id = category.Id,
                Name = category.Name,
                Slug = category.Slug,
                Description = category.Description,
                ThumbnailImage = category.ThumbnailImage
            };

            return result;
        }
    }
}