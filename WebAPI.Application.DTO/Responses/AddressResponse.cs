namespace WebAPI.Application.DTO.Responses
{
    public class AddressResponse
    {
        public string ZipCode { get; set; }
        public string PublicPlace { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}