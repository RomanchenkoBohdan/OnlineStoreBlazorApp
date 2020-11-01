using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using System.Collections.Generic;

namespace eShop.UseCases.SearchProductScreen
{
    public class SearchProduct : ISearchProduct
    {
        private readonly IProductRepositery productRepositery;

        public SearchProduct(IProductRepositery productRepositery)
        {
            this.productRepositery = productRepositery;
        }
        public IEnumerable<Product> Execute(string filter = null)
        {
            return productRepositery.GetProducts(filter);
        }
    }
}
