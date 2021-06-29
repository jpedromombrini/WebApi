namespace WebAPI.Application.DTO.Requests.Register
{
    public class UpdatePhysicalPersonRequest : UpdatePersonRequest
    {
         public string Cpf { get; set; }
        public string Name { get; set; }
    }
}