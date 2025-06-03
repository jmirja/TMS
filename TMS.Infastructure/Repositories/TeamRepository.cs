using Microsoft.EntityFrameworkCore;
using TMS.Domain.Entities;
using TMS.Domain.Interfaces;
using TMS.Infrastructure.Persistence;

namespace TMS.Infrastructure.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly ApplicationDbContext _context;

        public TeamRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Team>> GetAllAsync() =>
            await _context.Teams.ToListAsync();

        public async Task<Team?> GetByIdAsync(Guid id) =>
            await _context.Teams.FindAsync(id);

        public async Task AddAsync(Team team)
        {
            _context.Teams.Add(team);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Team team)
        {
            _context.Teams.Update(team);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var team = await _context.Teams.FindAsync(id);
            if (team is not null)
            {
                _context.Teams.Remove(team);
                await _context.SaveChangesAsync();
            }
        }
    }
}
