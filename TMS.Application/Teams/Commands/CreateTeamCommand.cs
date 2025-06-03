using MediatR;
using TMS.Application.DTOs;

namespace TMS.Application.Teams.Commands
{
    public record CreateTeamCommand(string Name, string? Description) : IRequest<TeamDto>;

}
