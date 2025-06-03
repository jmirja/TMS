using MediatR;
using TMS.Application.DTOs;

namespace TMS.Application.Teams.Queries
{
    public record GetTeamByIdQuery(Guid Id) : IRequest<TeamDto>;


}
