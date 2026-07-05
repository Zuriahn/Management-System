using ErrorOr;

namespace WebApp.UseCases.ProductCases.Interfaces
{
  public interface IViewRemoveProduct
  {
    public Task<ErrorOr<Guid>> ExecuteAsync(Guid id);
  }
}
