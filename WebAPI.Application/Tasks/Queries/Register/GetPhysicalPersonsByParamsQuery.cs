using System.Collections.Generic;
using MediatR;
using WebAPI.Application.DTO.Filters.Register;
using WebAPI.Application.DTO.Responses.Register;

namespace WebAPI.Application.Tasks.Queries.Register
{
    public class GetPhysicalPersonsByParamsQuery : IRequest<ResultTask<IEnumerable<PhysicalPersonResponse>>>
    {
        public GetPhysicalPersonsByParamsFilter Filter { get; set; }
        public GetPhysicalPersonsByParamsQuery(GetPhysicalPersonsByParamsFilter filter)
        {
            Filter = filter;
        }
    }
}