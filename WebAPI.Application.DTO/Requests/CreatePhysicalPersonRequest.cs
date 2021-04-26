namespace WebAPI.Application.DTO.Requests
{
    public class CreatePhysicalPersonRequest : CreatePersonRequest
    {
        public string Cpf { get; set; }
        public string Name { get; set; }
        
    }
}