﻿using LTS.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Crm.Domain.Models
{
    public class MenuItem : EntityBase
    {
        public long? ParentId { get; set; }

        public MenuItem Parent { get; set; }

        public IList<MenuItem> Children { get; protected set; } = new List<MenuItem>();

        public long MenuId { get; set; }

        public Menu Menu { get; set; }

        public long? EntityId { get; set; }

        public Entity Entity { get; set; }

        
        public string CustomLink { get; set; }

        public string Name { get; set; }

        public int DisplayOrder { get; set; }
    }
}
