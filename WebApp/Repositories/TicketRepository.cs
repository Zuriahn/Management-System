using Microsoft.EntityFrameworkCore;
using WebApp.EFConfiguration;
using WebApp.Entities;
using WebApp.Interfaces;

namespace WebApp.Repositories
{
  public class TicketRepository : ITicketRepository
  {
    private readonly ApplicationDbContext _applicationDbContext;

    public TicketRepository(ApplicationDbContext applicationDbContext)
    {
      _applicationDbContext = applicationDbContext;
    }

    public async Task AddAsync(Ticket ticket)
    {
      await _applicationDbContext.AddAsync(ticket);
    }

    public void Update(Ticket ticket)
    {
      _applicationDbContext.Update(ticket);
    }

    public void Disabled(Ticket ticket)
    {
      ticket.IsClosed = true;
      _applicationDbContext.Update(ticket);
    }

    public async Task<Ticket?> GetByIdAsync(Guid id)
    {
      return await _applicationDbContext.Tickets.SingleOrDefaultAsync(u => u.Id == id);
    }

    public async Task<List<Ticket>> GetAllAsync()
    {
      return await _applicationDbContext.Tickets.AsNoTracking().ToListAsync();
    }

  }
}
