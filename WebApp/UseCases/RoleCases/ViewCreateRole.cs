using WebApp.UseCases.Interfaces;
using WebApp.UseCases.RoleCases.Interfaces;

namespace WebApp.UseCases.RoleCases
{
  public class ViewCreateRole : IViewCreateRole
  {
    private readonly IRoleRepository _roleRepository;
    public ViewCreateRole(IRoleRepository roleRepository)
    {
      _roleRepository = roleRepository;
    }

    public async Task ExecuteAsync()
    {
      await Task.Delay(1000);
    }
  }
}
