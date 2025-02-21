using AutoMapper;
using TDM.Data.Entities;
using TDM.Service.DTOs;

public class MappingProfile : Profile
{
    public MappingProfile()
    {

        CreateMap<Role, RoleDto>();
        CreateMap<RoleDto, Role>();

        CreateMap<UserTask, TaskDto>();
        CreateMap<TaskDto, UserTask>();
    }
}
