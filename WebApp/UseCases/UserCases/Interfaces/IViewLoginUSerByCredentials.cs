using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.UserCases.Interfaces
{
  public interface IViewLoginUserByCredentials
  {
    public Task<ErrorOr<Guid>> ExecuteAsync(LoginUserVM credentials);
  }
}
