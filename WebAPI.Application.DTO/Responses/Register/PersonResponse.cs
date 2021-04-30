using System;
using WebAPI.Application.DTO.Enums;

namespace WebAPI.Application.DTO.Responses.Register
{
    public abstract class PersonResponse
    {
        public string Email { get; set; }
        public DateTime InclusionDate { get; set; }  
        public string Phone { get; set; }
        public PersonTypeEnum PersonType { get; set; }    
        public string Observation { get; set; }  
        public AddressResponse Address { get; set; }
    }
}