// ReSharper disable All
using System;
using System.Collections.Generic;
using MixERP.Net.Schemas.Core.Data;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.Api.Core.Fakes
{
    public class IsValidUnitIdRepository : IIsValidUnitIdRepository
    {
        public int PgArg0 { get; set; }

        public bool Execute()
        {
            return new bool();
        }
    }
}