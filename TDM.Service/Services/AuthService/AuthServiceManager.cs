using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDM.Data.Common.CommonUtilities;
using TDM.Data.DataManagers.CustomDataManagers;
using TDM.Data.Entities;
using TDM.Service.CustomDTOs;
using TDM.Service.DTOs;
namespace TDM.Service.Services.AuthService
{
    public class AuthServiceManager
    {
        private readonly AuthDataManager _authDataManager;
        private readonly IMapper _mapper;

        public AuthServiceManager(IMapper mapper)
        {
            _authDataManager =new AuthDataManager();
            _mapper = mapper;
        }
        public  Task<FunctionResponseEntity<UserDto>> RegisterUser(RegisterDto newUser)
        {
            FunctionResponseEntity<UserDto> response = new FunctionResponseEntity<UserDto>();
            FunctionResponseEntity<User> functionResponseEntity = _authDataManager.RegisterUser();
            //return Task.FromResult(_mapper.Map<FunctionResponseEntity<UserDto>>());
            var functionResponseDto = _mapper.Map<FunctionResponseEntity<UserDto>>(functionResponseEntity);
            return Task.FromResult(functionResponseDto);
        }

    }
}
