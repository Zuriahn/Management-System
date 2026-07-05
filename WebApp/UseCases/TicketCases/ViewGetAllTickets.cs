using WebApp.UseCases.Interfaces;
using WebApp.UseCases.TicketCases.Interfaces;
using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.TicketCases
{
  public class ViewGetAllTickets : IViewGetAllTickets
  {
    private readonly ITicketRepository _ticketRepository;
    public ViewGetAllTickets(ITicketRepository ticketRepository)
    {
      _ticketRepository = ticketRepository;
    }

    public async Task<ErrorOr<List<TicketVM>>> ExecuteAsync()
    {
      var tickets = await _ticketRepository.GetAllAsync();

      var ticketVMs = tickets.Select(t => new TicketVM(
        t.Id,
        t.Title,
        t.Description,
        t.ReviewDate,
        t.ReviewAnswer,
        t.IsClosed,
        t.UserId,
        t.ProductId
      )).ToList();

      return ticketVMs;
    }

  }
}
