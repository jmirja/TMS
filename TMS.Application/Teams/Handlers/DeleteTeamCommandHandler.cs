using MediatR;
using TMS.Application.Teams.Commands;
using TMS.Domain.Interfaces;

namespace TMS.Application.Teams.Handlers
{
    public class DeleteTeamCommandHandler : IRequestHandler<DeleteTeamCommand>
    {
        private readonly ITeamRepository _repo;

        public DeleteTeamCommandHandler(ITeamRepository repo)
        {
            _repo = repo;
        }

        public async Task<Unit> Handle(DeleteTeamCommand request, CancellationToken cancellationToken)
        {
            await _repo.DeleteAsync(request.Id);
            return Unit.Value;
        }
    }
}
