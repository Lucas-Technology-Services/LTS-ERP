using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Core.Events
{
    public class EntityViewed : INotification
    {
        public long EntityId { get; set; }

        public string EntityTypeId { get; set; }
        
    }
}