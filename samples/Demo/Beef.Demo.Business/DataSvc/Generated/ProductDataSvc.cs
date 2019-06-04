/*
 * This file is automatically generated; any changes will be lost. 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Beef;
using Beef.Business;
using Beef.Entities;
using Beef.Demo.Business.Data;
using Beef.Demo.Common.Entities;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Business.DataSvc
{
    /// <summary>
    /// Provides the Product data repository services.
    /// </summary>
    public static partial class ProductDataSvc
    {
        /// <summary>
        /// Gets the <see cref="Product"/> object that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Product"/> identifier.</param>
        /// <returns>The selected <see cref="Product"/> object where found; otherwise, <c>null</c>.</returns>
        public static Task<Product> GetAsync(int id)
        {
            return DataSvcInvoker.Default.InvokeAsync(typeof(ProductDataSvc), async () => 
            {
                var __key = new UniqueKey(id);
                if (ExecutionContext.Current.TryGetCacheValue<Product>(__key, out Product __val))
                    return __val;

                var __result = await Factory.Create<IProductData>().GetAsync(id);
                ExecutionContext.Current.CacheSet<Product>(__key, __result);
                return __result;
            });
        }      

        /// <summary>
        /// Gets the <see cref="Product"/> collection object that matches the selection criteria.
        /// </summary>
        /// <param name="args">The Args (see <see cref="ProductArgs"/>).</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        /// <returns>A <see cref="ProductCollectionResult"/>.</returns>
        public static Task<ProductCollectionResult> GetByArgsAsync(ProductArgs args, PagingArgs paging)
        {
            return DataSvcInvoker.Default.InvokeAsync(typeof(ProductDataSvc), async () => 
            {
                var __result = await Factory.Create<IProductData>().GetByArgsAsync(args, paging);
                return __result;
            });
        }      
    }
}