namespace Services.Common.Dto
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int ProviderId { get; set; }
        public string ProviderName { get; set; }
    }
}
