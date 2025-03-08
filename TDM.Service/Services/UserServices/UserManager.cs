using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDM.Data.Entities;
using TDM.Service.DTOs;

namespace TDM.Service.Services.UserServices
{
    public  class UserManager
    {
        private readonly IMapper _mapper;
        public UserManager(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Task<UserDto> GetUserDto(int userId)
        {
            User user = new User() { UserID = 1, FirstName = "admin", LastName = $"No problem usr id is -->: {userId}" ,BirthDate=DateTime.Today };
            return Task.FromResult(_mapper.Map<UserDto>(user));
        }

    }
}
