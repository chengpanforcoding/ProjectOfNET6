using SideProjectForNET6.Models;

namespace SideProjectForNET6.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(Guid id);

    }
}
