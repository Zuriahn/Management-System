using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.TicketCases.Interfaces
{
  public interface IViewGetAllTickets
  {
    public Task<ErrorOr<List<TicketVM>>> ExecuteAsync();
  }
}
