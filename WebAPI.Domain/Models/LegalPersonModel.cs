namespace WebAPI.Domain.Models
{
    public class LegalPersonModel : PersonModel
    {
        public string Cnpj { get; set; }
        public string CompanyName { get; set; }
        public string Subscription { get; set; }
        public string Fantasy { get; set; }
        public PersonModel Person { get; set; }
    }
}