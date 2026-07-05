using WebApp.Entities;

namespace WebApp.Interfaces
{
  public interface ITicketRepository
  {
    public Task AddAsync(Ticket ticket);

    public void Update(Ticket ticket);

    public void Disabled(Ticket ticket);

    public Task<Ticket?> GetByIdAsync(Guid id);
    public Task<List<Ticket>> GetAllAsync();
  }
}
