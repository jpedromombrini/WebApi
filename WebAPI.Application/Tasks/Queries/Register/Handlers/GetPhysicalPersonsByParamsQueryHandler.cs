using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using WebAPI.Application.DTO.Responses.Register;
using WebAPI.Domain.Core.Interfaces.Services.Register;

namespace WebAPI.Application.Tasks.Queries.Register.Handlers
{
    public class GetPhysicalPersonsByParamsQueryHandler : IRequestHandler<GetPhysicalPersonsByParamsQuery, ResultTask<IEnumerable<PhysicalPersonResponse>>>
    {
        private readonly IMapper _mapper;
        private readonly IPhysicalPersonService _physicalPersonService;
        public GetPhysicalPersonsByParamsQueryHandler(IMapper mapper, IPhysicalPersonService physicalPersonService)
        {
            _mapper = mapper;
            _physicalPersonService = physicalPersonService;
        }
        public async Task<ResultTask<IEnumerable<PhysicalPersonResponse>>> Handle(GetPhysicalPersonsByParamsQuery query, CancellationToken cancellationToken)
        {
            try
            {
                var result = new ResultTask<IEnumerable<PhysicalPersonResponse>>();
                var entities = await _physicalPersonService.GetByNameAsync(query.Filter.Name);
                result.Value = _mapper.Map<IEnumerable<PhysicalPersonResponse>>(entities);
                return result;                

            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}