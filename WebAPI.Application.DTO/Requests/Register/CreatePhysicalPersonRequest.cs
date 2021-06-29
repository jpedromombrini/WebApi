namespace WebAPI.Application.DTO.Requests.Register
{
    public class CreatePhysicalPersonRequest : CreatePersonRequest
    {
        public string Cpf { get; set; }
        public string Name { get; set; }
        
    }
}