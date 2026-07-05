using WebApp.UseCases.Interfaces;
using WebApp.UseCases.RoleCases.Interfaces;
using WebApp.Exceptions;
using ErrorOr;
using WebApp.Entities;
using WebApp.Models;

namespace WebApp.UseCases.RoleCases
{
  public class ViewCreateRole : IViewCreateRole
  {
    private readonly IRoleRepository _roleRepository;
    public ViewCreateRole(IRoleRepository roleRepository)
    {
      _roleRepository = roleRepository;
    }

    public async Task<ErrorOr<Guid>> ExecuteAsync(CreateRoleVM role)
    {
      if (role == null)
      {
        return Errors.Role.RoleIsEmpty;
      }

      var newRole = new Role(
          Guid.NewGuid(),
          role.Name
        );

      await _roleRepository.AddAsync(newRole);

      return newRole.Id;
    }

  }
}
