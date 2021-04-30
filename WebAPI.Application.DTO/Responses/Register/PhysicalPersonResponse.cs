namespace WebAPI.Application.DTO.Responses.Register
{
    public class PhysicalPersonResponse : PersonResponse
    {
        public string Cpf { get; set; }
        public string Name { get; set; }
    }
}