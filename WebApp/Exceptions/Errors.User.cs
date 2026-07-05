using ErrorOr;

namespace WebApp.Exceptions
{
  public static partial class Errors
  {
    public static class User
    {
      public static Error UserIsEmpty => Error.Validation("User", "No data found from the user is not valid");
    }

  }
}
