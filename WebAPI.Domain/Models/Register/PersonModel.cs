using System;
using WebAPI.Domain.Enums;

namespace WebAPI.Domain.Models.Register
{
    public abstract class PersonModel : BaseModel
    {
        public string Email { get; set; }
        public DateTime InclusionDate { get; set; }  
        public string Phone { get; set; }
        public PersonTypeEnum PersonType { get; set; }    
        public string Observation { get; set; }  
        public virtual AddressModel Address { get; set; }
        public LegalPersonModel LegalPerson { get; set; }           
        public PhysicalPersonModel PhysicalPerson { get; set; }
    }
}