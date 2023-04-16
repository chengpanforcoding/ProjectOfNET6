using ProjectOfNET6.Database;
using SideProjectForNET6.Models;

namespace SideProjectForNET6.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public Product GetProduct(Guid id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }
    }
}
