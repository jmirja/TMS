using MediatR;

namespace TMS.Application.Teams.Commands
{
    public record DeleteTeamCommand(Guid Id) : IRequest;


}
