using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDM.Data.Entities;
using TDM.Service.DTOs;

namespace TDM.Service.Services.RoleServices
{
    public class RoleManager
    {
        private readonly IMapper _mapper;

        public RoleManager(IMapper mapper)
        {
            _mapper = mapper;
        }

        public RoleDto GetRoleDto(int userId)
        {
            
            Role role = new Role() {RoleId=1,RoleName="admin",RoleDescription= $"No problem usr id is -->: {userId}" };
            return _mapper.Map<RoleDto>(role);
        }

        public Role GetRole(RoleDto roleDto)
        {
            return _mapper.Map<Role>(roleDto);
        }
    }
}
