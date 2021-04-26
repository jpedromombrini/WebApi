namespace WebAPI.Application.DTO.Requests
{
    public class CreateLegalPersonRequest : CreatePersonRequest
    {
        public string Cnpj { get; set; }
        public string CompanyName { get; set; }
        public string Subscription { get; set; }
        public string Fantasy { get; set; }
    }
}