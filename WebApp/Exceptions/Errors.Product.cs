using ErrorOr;

namespace WebApp.Exceptions
{
  public static partial class Errors
  {
    public static class Product
    {
      public static Error ProductIsEmpty => Error.Validation("Product", "The provided product data is not valid");

      public static Error NotFound => Error.NotFound("Product", "The product with the specified ID was not found");

    }

  }
}
