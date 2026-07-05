using ErrorOr;

namespace WebApp.Exceptions
{
  public static partial class Errors
  {
    public static class User
    {
      public static Error UserIsEmpty => Error.Validation("User", "No data found from the user is not valid");

      public static Error NotFound => Error.NotFound("User", "The user with the specified ID was not found");

      public static Error InvalidCredentials => Error.Unauthorized("User", "The email or password is incorrect");

      public static Error DuplicateEmail => Error.Conflict("User", "A user with this email address already exists");

    }

  }
}
