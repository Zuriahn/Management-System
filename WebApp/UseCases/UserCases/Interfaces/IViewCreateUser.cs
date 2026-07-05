using WebApp.Models;
using ErrorOr;

namespace WebApp.UseCases.UserCases.Interfaces
{
  public interface IViewCreateUser
  {
    public Task<ErrorOr<Guid>> ExecuteAsync(CreateUserVM user);
  }
}
