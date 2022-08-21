using AutoMapper;
using Infrastructure.DTO;
using Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Queries.GetCurrentUser
{
    public class GetCurrentUserQuery : IGetCurrentUserQuery
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public GetCurrentUserQuery(UserManager<User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }
        public async Task<UserDto> ExecuteAsync(GetCurrentUserFilter filter)
        {
            var currentUser = await _userManager.GetUserAsync(filter.Claims);
            return _mapper.Map<UserDto>(currentUser);
        }
    }
}
