namespace WebAPI.Domain.Models.Register
{
    public class PhysicalPersonModel : PersonModel
    {
        public string Cpf { get; set; }
        public string Name { get; set; }
        public PersonModel Person { get; set; } 
    }
}