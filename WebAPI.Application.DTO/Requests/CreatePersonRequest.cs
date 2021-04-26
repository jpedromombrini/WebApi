using System;
using WebAPI.Application.DTO.Enums;

namespace WebAPI.Application.DTO.Requests
{
    public abstract class CreatePersonRequest
    {
        public string Email { get; set; }
        public DateTime InclusionDate { get; set; }  
        public string Phone { get; set; }
        public PersonTypeEnum PersonType { get; set; }    
        public string Observation { get; set; }  
        public CreateAddressRequest Address { get; set; }
    }
}