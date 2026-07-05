using WebApp.UseCases.Interfaces;
using WebApp.UseCases.RoleCases.Interfaces;
using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.RoleCases
{
  public class ViewGetAllRoles : IViewGetAllRoles
  {
    private readonly IRoleRepository _roleRepository;
    public ViewGetAllRoles(IRoleRepository roleRepository)
    {
      _roleRepository = roleRepository;
    }

    public async Task<ErrorOr<List<RoleVM>>> ExecuteAsync()
    {
      var roles = await _roleRepository.GetAllAsync();

      var roleVMs = roles.Select(r => new RoleVM(
        r.Id,
        r.Name
      )).ToList();

      return roleVMs;
    }

  }
}
