using System;

namespace WebAPI.Domain.Models
{
    public class AddressModel : BaseModel
    {
        public string ZipCode { get; set; }
        public string PublicPlace { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Guid PersonId { get; set; }   
        public virtual PersonModel Person { get; set; }  
    }
}