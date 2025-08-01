using AutoMapper;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using DTOLayer.DTOs.CityDTOs;
using EntityLayer.Concrete;

namespace TraversalCoreProject.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDto, Announcement>().ReverseMap();
            CreateMap<AppUserRegisterDto, AppUser>().ReverseMap();
            CreateMap<AppUserLoginDto, AppUser>().ReverseMap();
        }
    }
}
