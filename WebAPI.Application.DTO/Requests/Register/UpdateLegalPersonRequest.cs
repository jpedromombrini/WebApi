namespace WebAPI.Application.DTO.Requests.Register
{
    public class UpdateLegalPersonRequest : UpdatePersonRequest
    {
        public string Cnpj { get; set; }
        public string CompanyName { get; set; }
        public string Subscription { get; set; }
        public string Fantasy { get; set; }
    }
}