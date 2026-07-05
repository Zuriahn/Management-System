using ErrorOr;

namespace WebApp.Exceptions
{
  public static partial class Errors
  {
    public static class Category
    {
      public static Error CategoryIsEmpty => Error.Validation("Category", "The provided category data is not valid");

      public static Error NotFound => Error.NotFound("Category", "The category with the specified ID was not found");

    }

  }
}
