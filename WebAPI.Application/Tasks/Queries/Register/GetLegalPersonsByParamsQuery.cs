using System.Collections.Generic;
using MediatR;
using WebAPI.Application.DTO.Filters.Register;
using WebAPI.Application.DTO.Responses.Register;

namespace WebAPI.Application.Tasks.Queries.Register
{
    public class GetLegalPersonsByParamsQuery : IRequest<ResultTask<IEnumerable<LegalPersonResponse>>>
    {
        public GetLegalPersonsByParamsFilter Filter { get; set; }
        public GetLegalPersonsByParamsQuery(GetLegalPersonsByParamsFilter filter)
        {
            Filter = filter;
        }
        
    }
}