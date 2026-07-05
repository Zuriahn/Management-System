using WebApp.UseCases.Interfaces;
using WebApp.UseCases.TicketCases.Interfaces;
using WebApp.Exceptions;
using ErrorOr;
using WebApp.Entities;
using WebApp.Models;

namespace WebApp.UseCases.TicketCases
{
  public class ViewCreateTicket : IViewCreateTicket
  {
    private readonly ITicketRepository _ticketRepository;
    public ViewCreateTicket(ITicketRepository ticketRepository)
    {
      _ticketRepository = ticketRepository;
    }

    public async Task<ErrorOr<Guid>> ExecuteAsync(CreateTicketVM ticket)
    {
      if (ticket == null)
      {
        return Errors.Ticket.TicketIsEmpty;
      }

      var newTicket = new Ticket(
          Guid.NewGuid(),
          ticket.Title,
          ticket.Description,
          ticket.ReviewDate,
          ticket.ReviewAnswer,
          ticket.IsClosed,
          ticket.UserId,
          ticket.ProductId
        );

      await _ticketRepository.AddAsync(newTicket);

      return newTicket.Id;
    }

  }
}
