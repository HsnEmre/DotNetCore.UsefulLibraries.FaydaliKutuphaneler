using AutoMapper;
using FluentValidation.App.DTO;
using FluentValidation.App.Models;

namespace FluentValidation.App.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(
                dest => dest.isim,
                opt => opt.MapFrom(
                    x => x.Name))
                .ForMember(x => x.eposta
                , x => x.MapFrom(
                    x => x.Mail))
                .ForMember(x => x.yaş,
                x => x.MapFrom(
                    x => x.Age)).ReverseMap();
        }
    }
}
