using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using System.Linq;
using WebAPI.Application.DTO.Responses.Register;
using WebAPI.Domain.Core.Interfaces.Services.Register;

namespace WebAPI.Application.Tasks.Queries.Register.Handlers
{
    public class GetLegalPersonsByParamsQueryHandler : IRequestHandler<GetLegalPersonsByParamsQuery, ResultTask<IEnumerable<LegalPersonResponse>>>
    {
        private readonly IMapper _mapper;
        private readonly ILegalPersonService _legalPersonService;
        public GetLegalPersonsByParamsQueryHandler(IMapper mapper, ILegalPersonService legalPersonService)
        {
            _mapper = mapper;
            _legalPersonService = legalPersonService;
        }
        
        public async Task<ResultTask<IEnumerable<LegalPersonResponse>>> Handle(GetLegalPersonsByParamsQuery query, CancellationToken cancellationToken)
        {
            try
            {
                var result = new ResultTask<IEnumerable<LegalPersonResponse>>();
                var entities = await _legalPersonService.GetByCompanyNameAsync(query.Filter.CompanyName);
                result.Value = _mapper.Map<IEnumerable<LegalPersonResponse>>(entities);
                return result;                
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}