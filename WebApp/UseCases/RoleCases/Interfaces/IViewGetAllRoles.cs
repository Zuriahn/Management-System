using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.RoleCases.Interfaces
{
  public interface IViewGetAllRoles
  {
    public Task<ErrorOr<List<RoleVM>>> ExecuteAsync();
  }
}
