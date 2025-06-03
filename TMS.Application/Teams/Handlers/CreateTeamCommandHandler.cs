using MediatR;
using TMS.Application.DTOs;
using TMS.Application.Teams.Commands;
using TMS.Domain.Entities;
using TMS.Domain.Interfaces;

namespace TMS.Application.Teams.Handlers
{
    public class CreateTeamCommandHandler : IRequestHandler<CreateTeamCommand, TeamDto>
    {
        private readonly ITeamRepository _repo;

        public CreateTeamCommandHandler(ITeamRepository repo)
        {
            _repo = repo;
        }

        public async Task<TeamDto> Handle(CreateTeamCommand request, CancellationToken cancellationToken)
        {
            var team = new Team
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description
            };

            await _repo.AddAsync(team);

            return new TeamDto
            {
                Id = team.Id,
                Name = team.Name,
                Description = team.Description
            };
        }
    }
}
