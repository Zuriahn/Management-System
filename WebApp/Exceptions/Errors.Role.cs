using ErrorOr;

namespace WebApp.Exceptions
{
  public static partial class Errors
  {
    public static class Role
    {
      public static Error RoleIsEmpty => Error.Validation("Role", "The provided role data is not valid");

    }

  }
}
