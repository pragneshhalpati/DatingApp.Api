using System.Linq;
using AutoMapper;
using DatingApp.API.Dtos;
using DatingApp.API.Helpers;
using DatingApp.API.Models;

namespace DatingApp.API.Controllers.Helpers
{
    public class AutoMApperProfiles : Profile
    {
        public AutoMApperProfiles(){
            CreateMap<User,UserForListDto>()
            .ForMember(dest =>dest.PhotoUrl,opt=> {
                opt.MapFrom(src=>src.Photos.FirstOrDefault(p =>p.IsMain).Url);
            })
            .ForMember(dest =>dest.Age,opt=> {
                opt.ResolveUsing(d=>d.DateOfBirth.CalculateAge());
            });
            CreateMap<User,UserForDetailDto>()
             .ForMember(dest =>dest.PhotoUrl,opt=> {
                opt.MapFrom(src=>src.Photos.FirstOrDefault(p =>p.IsMain).Url);
            })
            .ForMember(dest =>dest.Age,opt=> {
                opt.ResolveUsing(d=>d.DateOfBirth.CalculateAge());
            });
            CreateMap<User,PhotosForDetailedDto>();
        }
    }
}