using AutoMapper;
using FluentValidation.App.DTO;
using FluentValidation.App.Models;

namespace FluentValidation.App.Mapping
{
    public class EventDateProfile : Profile
    {
        public EventDateProfile()
        {
            CreateMap<EvenDateDto, EventDate>().ForMember(x => x.Date, opt => opt.MapFrom(x => new DateTime(x.Year, x.Month, x.Day)));
            //custom islemlerde reverse map calismiyor
            CreateMap<EventDate, EvenDateDto>().ForMember(x => x.Year, opt
                => opt.MapFrom(x => x.Date.Year))
                .ForMember(x => x.Month, opt => opt.MapFrom(x => x.Date.Month))
                .ForMember(x => x.Day, opt => opt.MapFrom(x => x.Date.Day));
        }
    }
}
