using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.UserCases.Interfaces
{
  public interface IViewUpdateUser
  {
    public Task<ErrorOr<Guid>> ExecuteAsync(Guid userId, UpdateUserVM user);
  }
}
