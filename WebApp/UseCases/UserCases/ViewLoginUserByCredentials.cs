using WebApp.UseCases.Interfaces;
using WebApp.UseCases.UserCases.Interfaces;

namespace WebApp.UseCases.UserCases
{
  public class ViewLoginUserByCredentials : IViewLoginUSerByCredentials
  {
    private readonly IUserRepository _userRepository;
    public ViewLoginUserByCredentials(IUserRepository userRepository) 
    {
      _userRepository = userRepository;
    }

    public async Task ExecuteAsync()
    {
      await Task.Delay(1000);
    }

  }
}
