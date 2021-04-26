namespace WebAPI.Domain.Models
{
    public class PhysicalPersonModel : PersonModel
    {
        public string Cpf { get; set; }
        public string Name { get; set; }
        public PersonModel Person { get; set; } 
    }
}