using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.TicketCases.Interfaces
{
  public interface IViewGetTicketById
  {
    public Task<ErrorOr<TicketVM>> ExecuteAsync(Guid id);
  }
}
