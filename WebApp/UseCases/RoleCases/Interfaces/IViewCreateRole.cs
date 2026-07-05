using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.RoleCases.Interfaces
{
  public interface IViewCreateRole
  {
    public Task<ErrorOr<Guid>> ExecuteAsync(CreateRoleVM role);
  }
}
