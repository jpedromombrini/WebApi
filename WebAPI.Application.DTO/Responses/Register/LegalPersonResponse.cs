namespace WebAPI.Application.DTO.Responses.Register
{
    public class LegalPersonResponse : PersonResponse
    {
        public string Cnpj { get; set; }
        public string CompanyName { get; set; }
        public string Subscription { get; set; }
        public string Fantasy { get; set; }
    }
}