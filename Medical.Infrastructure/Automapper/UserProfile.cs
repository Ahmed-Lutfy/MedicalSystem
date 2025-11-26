using AutoMapper;
using Medical.Application.DTO;
using Medical.Infrastructure.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Application.Automapper
{
   public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserLoginRequest>().ReverseMap();
            CreateMap<ApplicationUser, UserRegisterRequest>().ReverseMap();
            CreateMap<ApplicationUser, UserResponse>().ReverseMap();

            CreateMap<ApplicationUser, UserAccessToken>().ReverseMap();

        }
    }
}
