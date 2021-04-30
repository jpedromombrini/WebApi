namespace WebAPI.Application.DTO.Requests.Register
{
    public class CreateAddressRequest
    {
        public string ZipCode { get; set; }
        public string PublicPlace { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        
    }
}