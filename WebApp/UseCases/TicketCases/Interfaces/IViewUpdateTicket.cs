using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.TicketCases.Interfaces
{
  public interface IViewUpdateTicket
  {
    public Task<ErrorOr<Guid>> ExecuteAsync(Guid id, UpdateTicketVM ticket);
  }
}
