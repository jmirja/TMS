using MediatR;
using TMS.Application.DTOs;
using TMS.Application.Teams.Queries;
using TMS.Domain.Interfaces;

namespace TMS.Application.Teams.Handlers
{
    public class GetTeamByIdQueryHandler : IRequestHandler<GetTeamByIdQuery, TeamDto>
    {
        private readonly ITeamRepository _repo;

        public GetTeamByIdQueryHandler(ITeamRepository repo)
        {
            _repo = repo;
        }

        public async Task<TeamDto> Handle(GetTeamByIdQuery request, CancellationToken cancellationToken)
        {
            var team = await _repo.GetByIdAsync(request.Id)
                       ?? throw new KeyNotFoundException("Team not found");

            return new TeamDto
            {
                Id = team.Id,
                Name = team.Name,
                Description = team.Description
            };
        }
    }
}
