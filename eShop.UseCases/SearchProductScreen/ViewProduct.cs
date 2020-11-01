using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;

namespace eShop.UseCases.SearchProductScreen
{
    public class ViewProduct : IViewProduct
    {
        private readonly IProductRepositery productRepositery;

        public ViewProduct(IProductRepositery productRepositery)
        {
            this.productRepositery = productRepositery;
        }
        public Product Execute(int id)
        {
            return productRepositery.GetProduct(id);
        }
    }
}
