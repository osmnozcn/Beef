﻿using Beef.Data.OData;
using Beef.Demo.Common.Entities;
using Simple.OData.Client;

namespace Beef.Demo.Business.Data
{
    public partial class ProductData
    {
        public ProductData()
        {
            _getByArgsOnQuery = GetByArgs_OnQuery;
        }

        private IBoundClient<Model.Product> GetByArgs_OnQuery(IBoundClient<Model.Product> q, ProductArgs args, IODataArgs _)
        {
            return q.FilterWildcard(p => p.Name, args?.Name)
                    .FilterWildcard(p => p.Description, args?.Description);
        }
    }
}