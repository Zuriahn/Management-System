using WebApp.UseCases.Interfaces;
using WebApp.UseCases.TicketCases.Interfaces;
using WebApp.Exceptions;
using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.TicketCases
{
  public class ViewUpdateTicket : IViewUpdateTicket
  {
    private readonly ITicketRepository _ticketRepository;
    public ViewUpdateTicket(ITicketRepository ticketRepository)
    {
      _ticketRepository = ticketRepository;
    }

    public async Task<ErrorOr<Guid>> ExecuteAsync(Guid id, UpdateTicketVM ticket)
    {
      if (ticket == null)
      {
        return Errors.Ticket.TicketIsEmpty;
      }

      var existingTicket = await _ticketRepository.GetByIdAsync(id);
      if (existingTicket == null)
      {
        return Errors.Ticket.NotFound;
      }

      existingTicket.Title = ticket.Title;
      existingTicket.Description = ticket.Description;
      existingTicket.ReviewDate = ticket.ReviewDate;
      existingTicket.ReviewAnswer = ticket.ReviewAnswer;
      existingTicket.IsClosed = ticket.IsClosed;
      existingTicket.ProductId = ticket.ProductId;

      _ticketRepository.Update(existingTicket);

      return existingTicket.Id;
    }

  }
}
