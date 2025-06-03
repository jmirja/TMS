using MediatR;

namespace TMS.Application.Teams.Commands
{
    public record UpdateTeamCommand(Guid Id, string Name, string? Description) : IRequest;


}
