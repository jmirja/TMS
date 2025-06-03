using MediatR;
using TMS.Application.Teams.Commands;
using TMS.Domain.Interfaces;

namespace TMS.Application.Teams.Handlers
{
    public class UpdateTeamCommandHandler : IRequestHandler<UpdateTeamCommand>
    {
        private readonly ITeamRepository _repo;

        public UpdateTeamCommandHandler(ITeamRepository repo)
        {
            _repo = repo;
        }

        public async Task<Unit> Handle(UpdateTeamCommand request, CancellationToken cancellationToken)
        {
            var team = await _repo.GetByIdAsync(request.Id)
                       ?? throw new KeyNotFoundException("Team not found");

            team.Name = request.Name;
            team.Description = request.Description;

            await _repo.UpdateAsync(team);
            return Unit.Value;
        }
    }
}
