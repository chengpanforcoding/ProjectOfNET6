using Microsoft.EntityFrameworkCore;
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
            return _context.Products.Include(x => x.ProductPictures).FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> GetProducts(string keyword, string operatorType, int? ratingValue)
        {
            IQueryable<Product> result = _context.Products.Include(x => x.ProductPictures);
            if(!string.IsNullOrWhiteSpace(keyword)) // 和IsNullOrEmpty的差別只差在多檢查空格字串(" " 這個傳進來也會是false，但在IsNullOrEmpty會是true)
            {
                keyword = keyword.Trim();
                result = result.Where(x => x.Title.Contains(keyword));
            }
            if (ratingValue >= 0) //ratingValue大於等於零，才需要篩選
            {
                switch (operatorType) //operatorType
                {
                    case "largerThan":
                        result = result.Where(x => x.Rating >= ratingValue);
                        break;
                    case "lessThan":
                        result = result.Where(x=>x.Rating <= ratingValue);
                        break;
                    case "equalTo":
                        result = result.Where(x=>x.Rating == ratingValue);
                        break;
                    default:
                        break; //若switch不到不用處理，因為一樣還是維持原先的IQueryable result
                }
            }
            return result.ToList(); //IQueryable 上執行列舉方法時（如 ToList()、FirstOrDefault() 等），EFCore才會將LINQ轉換為相應的 SQL 語句並執行搜索。
                                    //注意，如果將查詢運算式轉換為 IEnumerable 類型，也會觸發立即搜索
                                    //所以就算28行不加To.List()讓他維持IQueryable 但因為method是傳回IEnumerable，所以也不會出錯XDD
        }

        public bool ProductExist(Guid id)
        {
            return _context.Products.Any(x => x.Id == id);
        }
        public IEnumerable<ProductPicture> GetPicturesByProductId(Guid id)
        {
            return _context.ProductPictures.Where(x => x.ProductId == id).ToList();
        }
        public ProductPicture GetPictureByPictureId(int id)
        {
            return _context.ProductPictures.Where(x => x.Id == id).FirstOrDefault();
        }

        public void AddProduct(Product product)
        {
            if(product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            _context.Products.Add(product);
        }

        public bool Save()
        {
            return _context.SaveChanges() >= 0;
        }

        public void AddProductPicture(Guid id, ProductPicture picture)
        {
            if(id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if(picture == null)
            {
                throw new ArgumentNullException(nameof(picture));
            }
            picture.ProductId = id;
            _context.ProductPictures.Add(picture);
        }

        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
        }

        public void DeleteProductPicture(ProductPicture productPicture)
        {
            _context.ProductPictures.Remove(productPicture);
        }

        public IEnumerable<Product> GetProductByIDList(IEnumerable<Guid> ids)
        {
            return _context.Products.Where(x => ids.Contains(x.Id)).ToList();
        }

        public void DeleteProducts(IEnumerable<Product> products)
        {
            _context.Products.RemoveRange(products);
        }
    }
}
