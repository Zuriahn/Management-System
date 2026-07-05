using ErrorOr;

namespace WebApp.Exceptions
{
  public static partial class Errors
  {
    public static class Ticket
    {
      public static Error TicketIsEmpty => Error.Validation("Ticket", "The provided ticket data is not valid");

      public static Error NotFound => Error.NotFound("Ticket", "The ticket with the specified ID was not found");

    }

  }
}
