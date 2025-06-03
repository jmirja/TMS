namespace TMS.Application.DTOs
{
    public class TeamDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
    }
}
