using PeoplePartnershipTest.DTOs;
using AutoMapper;

namespace PeoplePartnershipTest
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<StudioItem, GetStudioItemDto>();
            CreateMap<AddStudioItemDto, StudioItem>();
            CreateMap<StudioItem, GetStudioItemHeaderDto>();
        }
    }
}