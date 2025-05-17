using TMS.Domain.Enums;

namespace TMS.Application.DTOs
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public UserRole Role { get; set; } = default!;
    }
}
