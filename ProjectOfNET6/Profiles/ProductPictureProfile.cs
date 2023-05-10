using AutoMapper;
using ProjectOfNET6.Dtos;
using SideProjectForNET6.Models;

namespace ProjectOfNET6.Profiles
{
    public class ProductPictureProfile : Profile
    {
        public ProductPictureProfile()
        {
            CreateMap<ProductPicture, ProductPictureDto>();
            CreateMap<ProductPictureForCreationDto, ProductPicture>();
            CreateMap<ProductPicture, ProductPictureForCreationDto>();
        }
    }
}
