using MediatR;
using TMS.Application.DTOs;
using TMS.Application.Teams.Queries;
using TMS.Domain.Interfaces;

namespace TMS.Application.Teams.Handlers
{
    public class GetAllTeamsQueryHandler : IRequestHandler<GetAllTeamsQuery, IEnumerable<TeamDto>>
    {
        private readonly ITeamRepository _repo;

        public GetAllTeamsQueryHandler(ITeamRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<TeamDto>> Handle(GetAllTeamsQuery request, CancellationToken cancellationToken)
        {
            var teams = await _repo.GetAllAsync();

            return teams.Select(team => new TeamDto
            {
                Id = team.Id,
                Name = team.Name,
                Description = team.Description
            });
        }
    }

}
