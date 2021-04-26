namespace WebAPI.Application.DTO.Responses
{
    public class PhysicalPersonResponse : PersonResponse
    {
        public string Cpf { get; set; }
        public string Name { get; set; }
    }
}