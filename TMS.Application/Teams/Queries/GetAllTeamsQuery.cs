using MediatR;
using TMS.Application.DTOs;

namespace TMS.Application.Teams.Queries
{
    public record GetAllTeamsQuery : IRequest<IEnumerable<TeamDto>>;


}
