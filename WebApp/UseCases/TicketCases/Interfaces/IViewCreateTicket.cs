using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.TicketCases.Interfaces
{
  public interface IViewCreateTicket
  {
    public Task<ErrorOr<Guid>> ExecuteAsync(CreateTicketVM ticket);
  }
}
