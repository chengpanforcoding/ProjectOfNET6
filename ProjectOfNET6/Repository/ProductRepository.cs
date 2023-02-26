using SideProjectForNET6.Models;

namespace SideProjectForNET6.Repository
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;

        public ProductRepository()
        {
            if (_products == null)
            {
                InitiallizeMockData();
            }
        }

        private void InitiallizeMockData()
        {
            _products = new List<Product>()
            {
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Title = "淡水",
                    Description = "淡水漁人碼頭真好看",
                    OriginalPrice = 1299,
                    Features = "含郵輪體驗",
                    Notes = "很貴",
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Title = "礁溪",
                    Description = "溫泉之旅",
                    OriginalPrice = 2500,
                    Features = "含甕窯雞",
                    Notes = "很貴貴",
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Title = "東港",
                    Description = "大鵬灣真好玩",
                    OriginalPrice = 3000,
                    Features = "含SUP體驗",
                    Notes = "很貴貴貴",
                }
            };
        }

        public Product GetProduct(Guid id)
        {
            return _products.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }
    }
}
