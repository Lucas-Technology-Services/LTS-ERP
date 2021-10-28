﻿using LucasTechnologyServices.Module.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;

namespace LucasTechnologyServices.Module.Core.Models
{
    public class Entity : EntityBase
    {
        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public string Slug { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(450)]
        public string Name { get; set; }

        public long EntityId { get; set; }

        [StringLength(450)]
        public string EntityTypeId { get; set; }

        public EntityType EntityType { get; set; }
    }
}
