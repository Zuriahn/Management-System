using WebApp.UseCases.Interfaces;
using WebApp.UseCases.TicketCases.Interfaces;

namespace WebApp.UseCases.TicketCases
{
  public class ViewGetTicketById : IViewGetTicketById
  {
    private readonly ITicketRepository _ticketRepository;
    public ViewGetTicketById(ITicketRepository ticketRepository)
    {
      _ticketRepository = ticketRepository;
    }

    public async Task ExecuteAsync()
    {
      await Task.Delay(1000);
    }
  }
}
