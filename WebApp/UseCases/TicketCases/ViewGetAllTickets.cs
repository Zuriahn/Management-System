using WebApp.UseCases.Interfaces;
using WebApp.UseCases.TicketCases.Interfaces;

namespace WebApp.UseCases.TicketCases
{
  public class ViewGetAllTickets : IViewGetAllTickets
  {
    private readonly ITicketRepository _ticketRepository;
    public ViewGetAllTickets(ITicketRepository ticketRepository)
    {
      _ticketRepository = ticketRepository;
    }

    public async Task ExecuteAsync()
    {
      await Task.Delay(1000);
    }
  }
}
