using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDM.Service.Common.CommonUtilities
{
    public class FunctionResponseConverter<TSource, TDestination>
        : ITypeConverter<FunctionResponse<TSource>, FunctionResponse<TDestination>>
    {
        private readonly IMapper _mapper;

        public FunctionResponseConverter(IMapper mapper)
        {
            _mapper = mapper;
        }

        public FunctionResponse<TDestination> Convert(
            FunctionResponse<TSource> source, FunctionResponse<TDestination> destination, ResolutionContext context)
        {
            return new FunctionResponse<TDestination>
            {
                Success = source.Success,
                HttpStatusCode = source.HttpStatusCode,
                Message = source.Message,
                Data = _mapper.Map<TDestination>(source.Data), // Map main data
                //AdditionalData = source.AdditionalData, // Pass auxiliary data as is
                //GenericObject = source.GenericObject != null ? _mapper.Map<TDestination>(source.GenericObject) : default,
                //ErrorList = source.ErrorList?.ToList() ?? new List<string>(),
                //Warnings = source.Warnings?.ToList() ?? new List<string>(),
                //ResultCount = source.ResultCount,
                //TotalRecords = source.TotalRecords,
                //CorrelationId = source.CorrelationId,
                //Timestamp = source.Timestamp,
                //ExecutionTimeInSeconds = source.ExecutionTimeInSeconds,
                //DebugInfo = source.DebugInfo
            };
        }
    }

}
