namespace WebAPI.Domain.Models.Security
{
    public class UserModel : BaseModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
    }
}