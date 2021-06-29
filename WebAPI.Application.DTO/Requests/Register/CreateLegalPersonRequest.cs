namespace WebAPI.Application.DTO.Requests.Register
{
    public class CreateLegalPersonRequest : CreatePersonRequest
    {
        public string Cnpj { get; set; }
        public string CompanyName { get; set; }
        public string Subscription { get; set; }
        public string Fantasy { get; set; }
    }
}