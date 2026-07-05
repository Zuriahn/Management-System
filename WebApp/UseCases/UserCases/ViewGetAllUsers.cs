using WebApp.UseCases.Interfaces;
using WebApp.UseCases.UserCases.Interfaces;

namespace WebApp.UseCases.UserCases
{
  public class ViewGetAllUsers : IViewGetAllUsers
  {
    private readonly IUserRepository _userRepository;
    public ViewGetAllUsers(IUserRepository userRepository)
    {
      _userRepository = userRepository;
    }

    public async Task ExecuteAsync()
    {
      await Task.Delay(1000);
    }
  }
}
