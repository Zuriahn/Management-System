using WebApp.UseCases.Interfaces;
using WebApp.UseCases.RoleCases.Interfaces;

namespace WebApp.UseCases.RoleCases
{
  public class ViewGetAllRoles : IViewGetAllRoles
  {
    private readonly IRoleRepository _roleRepository;
    public ViewGetAllRoles(IRoleRepository roleRepository)
    {
      _roleRepository = roleRepository;
    }

    public async Task ExecuteAsync()
    {
      await Task.Delay(1000);
    }
  }
}
