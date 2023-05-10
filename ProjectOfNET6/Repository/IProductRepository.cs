using ProjectOfNET6.Dtos;
using SideProjectForNET6.Models;

namespace SideProjectForNET6.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts(string keyword,string operatorType,int? ratingValue);
        Product GetProduct(Guid id);
        bool ProductExist(Guid id);
        IEnumerable<ProductPicture> GetPicturesByProductId(Guid id);
        ProductPicture GetPictureByPictureId(int id);
        void AddProduct(Product product);
        void AddProductPicture(Guid id,ProductPicture picture);
        bool Save();
        void DeleteProduct(Product product);
        void DeleteProductPicture(ProductPicture productPicture);
        IEnumerable<Product> GetProductByIDList(IEnumerable<Guid> ids);

        void DeleteProducts(IEnumerable<Product> products);

    }
}
