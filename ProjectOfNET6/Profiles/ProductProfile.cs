using AutoMapper;
using ProjectOfNET6.Dtos;
using SideProjectForNET6.Models;

namespace ProjectOfNET6.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(
                dest => dest.Price,
                opt => opt.MapFrom(src => src.OriginalPrice * (decimal)(src.DiscountPersent ?? 1))
                )
                .ForMember(
                dest => dest.TradeDays,
                opt => opt.MapFrom(src => src.TradeDays.ToString())
                )
                .ForMember(
                dest => dest.TripType,
                opt => opt.MapFrom(src => src.TripType.ToString())
                )
                .ForMember(
                dest => dest.DepartureCity,
                opt => opt.MapFrom(src => src.DepartureCity.ToString())
                );
            CreateMap<ProductForCreationDto, Product>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => Guid.NewGuid())
                );
            CreateMap<ProductForUpdateDto, Product>();
            CreateMap<Product, ProductForUpdateDto>();
        }
    }
}
