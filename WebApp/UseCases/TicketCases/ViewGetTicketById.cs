using WebApp.UseCases.Interfaces;
using WebApp.UseCases.TicketCases.Interfaces;
using WebApp.Exceptions;
using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.TicketCases
{
  public class ViewGetTicketById : IViewGetTicketById
  {
    private readonly ITicketRepository _ticketRepository;
    public ViewGetTicketById(ITicketRepository ticketRepository)
    {
      _ticketRepository = ticketRepository;
    }

    public async Task<ErrorOr<TicketVM>> ExecuteAsync(Guid id)
    {
      var ticket = await _ticketRepository.GetByIdAsync(id);
      if (ticket == null)
      {
        return Errors.Ticket.NotFound;
      }

      var ticketVM = new TicketVM(
        ticket.Id,
        ticket.Title,
        ticket.Description,
        ticket.ReviewDate,
        ticket.ReviewAnswer,
        ticket.IsClosed,
        ticket.UserId,
        ticket.ProductId
      );

      return ticketVM;
    }

  }
}
