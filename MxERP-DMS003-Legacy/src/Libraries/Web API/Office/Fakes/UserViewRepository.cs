// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using MixERP.Net.Schemas.Office.Data;
using MixERP.Net.EntityParser;
using PetaPoco;
using CustomField = PetaPoco.CustomField;

namespace MixERP.Net.Api.Office.Fakes
{
    public class UserViewRepository : IUserViewRepository
    {
        public long Count()
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Office.UserView> Get()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.UserView(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Office.UserView> GetPaginatedResult()
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.UserView(), 1);
        }

        public IEnumerable<MixERP.Net.Entities.Office.UserView> GetPaginatedResult(long pageNumber)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.UserView(), 1);
        }

        public IEnumerable<DisplayField> GetDisplayFields()
        {
            return Enumerable.Repeat(new DisplayField(), 1);
        }


        public long CountWhere(List<EntityParser.Filter> filters)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Office.UserView> GetWhere(long pageNumber, List<EntityParser.Filter> filters)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.UserView(), 1);
        }

        public List<EntityParser.Filter> GetFilters(string catalog, string filterName)
        {
            return Enumerable.Repeat(new EntityParser.Filter(), 1).ToList();
        }

        public long CountFiltered(string filterName)
        {
            return 1;
        }

        public IEnumerable<MixERP.Net.Entities.Office.UserView> GetFiltered(long pageNumber, string filterName)
        {
            return Enumerable.Repeat(new MixERP.Net.Entities.Office.UserView(), 1);
        }

    }
}