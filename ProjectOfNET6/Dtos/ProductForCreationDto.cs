using ProjectOfNET6.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace ProjectOfNET6.Dtos
{
    //[ProductTitleMustBeDifferentFromDescriptionAttribute]
    public class ProductForCreationDto : ProductForManipulationDto //: IValidatableObject //0506 重構為class等級的filter //0507 重構為父類別共用，因為put更新api開發，也需要相同的數據驗證邏輯
    {
        //[Required(ErrorMessage ="Title不可為空")]
        //[MaxLength(100)]
        //public string Title { get; set; }
        //[Required]
        //[MaxLength(1500)]
        //public string Description { get; set; }
        //public decimal OriginalPrice { get; set; }
        //public double? DiscountPersent { get; set; }
        //public DateTime CreateTime { get; set; }
        //public DateTime? UpdateTime { get; set; }
        //public DateTime? GoTouristTime { get; set; }
        //public string? Features { get; set; }
        //public string? Fees { get; set; }
        //public string? Notes { get; set; }
        //public double? Rating { get; set; }
        //public string? TradeDays { get; set; }
        //public string? TripType { get; set; }
        //public string? DepartureCity { get; set; }
        //public ICollection<ProductPictureForCreationDto> ProductPictures { get; set; } //如果名稱與ORM Model相同，automapper就可以直接對應並映射
        //                                                                               //記得也要註冊子資源的profile映射關係 ex. ProductPictureForCreationDto To ProductPicture
        //                                                                               //這樣才能一次建立父子資源
        //       = new List<ProductPictureForCreationDto>();

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) //0506 重構為class等級的filter
        //{
        //    if(Title == Description)
        //    {
        //        yield return new ValidationResult("產品名稱需要和產品描述不同", new string[] { "ProductPictureForCreationDto" });
        //    }
        //}
    }
}
