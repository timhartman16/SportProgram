using AutoMapper;
using Domain.SportTrainingAggregate;
using Infrastructure.DTO;
using Infrastructure.Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mapper
{
    public class MainMapper : Profile
    {
        public MainMapper()
        {
            CreateMap<SportTraining, SportTrainingDto>();
            //CreateMap<IEnumerable<SportTraining>, IEnumerable<SportTrainingDto>>();
            CreateMap<Role, RoleDto>();
            CreateMap<User, UserDto>();
        }
    }
}
