using System.ComponentModel.DataAnnotations;

namespace Services.Common.Dto
{
    public class RegisterUserDto
    {
        public int ProviderId { get; set; }
        [Required]
        public string  Email { get; set; }
        [Required]
        public string  Password { get; set; }

        public int RoleId { get; set; }
    }
}
