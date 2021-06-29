using System;
using WebAPI.Application.DTO.Enums;

namespace WebAPI.Application.DTO.Requests.Register
{
    public abstract class UpdatePersonRequest
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public DateTime InclusionDate { get; set; }  
        public string Phone { get; set; }
        public PersonTypeEnum PersonType { get; set; }    
        public string Observation { get; set; }  
        public UpdateAddressRequest Address { get; set; }
    }
}