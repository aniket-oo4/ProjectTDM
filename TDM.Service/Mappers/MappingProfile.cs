using AutoMapper;
using TDM.Data.CustomEntities;
using TDM.Data.Entities;
using TDM.Service.Common.CommonUtilities;
using TDM.Service.CustomDTOs;
using TDM.Service.DTOs;

public class MappingProfile : Profile
{
    public MappingProfile()
    {

        CreateMap<Role, RoleDto>();
        CreateMap<RoleDto, Role>();

        CreateMap<User, UserDto>();
        CreateMap<UserDto, User>();

        CreateMap<UserTask, TaskDto>();
        CreateMap<TaskDto, UserTask>();

        CreateMap<TaskType, TaskTypeDto>();
        CreateMap<TaskTypeDto, TaskType>();

        CreateMap<Status, StatusDto>();
        CreateMap<StatusDto, Status>();

        CreateMap<TaskHistory, TaskHistoryDto>();
        CreateMap<TaskHistoryDto, TaskHistory>();

        CreateMap<TaskPriority, TaskPriorityDto>();
        CreateMap<TaskPriorityDto, TaskPriority>();

        CreateMap<TaskUpdate, TaskUpdateDto>();
        CreateMap<TaskUpdateDto, TaskUpdate>();

        CreateMap<ProjectDto, Project>();
        CreateMap<Project, ProjectDto>();

        CreateMap<Organisation, OrganisationDto>();
        CreateMap<OrganisationDto, Organisation>();


        /// <summary>
        /// below are the mappings for the custom entities
        /// 
        CreateMap<RegisterDto, RegisterEntity>();
        CreateMap<RegisterEntity, RegisterDto>();

        CreateMap(typeof(TDM.Data.Common.CommonUtilities.FunctionResponseEntity<>), typeof(TDM.Service.Common.CommonUtilities.FunctionResponse<>));
        CreateMap(typeof(TDM.Service.Common.CommonUtilities.FunctionResponse<>), typeof(TDM.Data.Common.CommonUtilities.FunctionResponseEntity<>));

        CreateMap(typeof(TDM.Service.Common.CommonUtilities.FunctionResponse<>), typeof(TDM.Data.Common.CommonUtilities.FunctionResponseEntity<>))
        .ConvertUsing(typeof(FunctionResponseConverter<,>));


    }
}
