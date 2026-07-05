using WebApp.UseCases.Interfaces;
using WebApp.UseCases.UserCases.Interfaces;
using WebApp.Exceptions;
using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.UserCases
{
  public class ViewLoginUserByCredentials : IViewLoginUserByCredentials
  {
    private readonly IUserRepository _userRepository;
    public ViewLoginUserByCredentials(IUserRepository userRepository)
    {
      _userRepository = userRepository;
    }

    public async Task<ErrorOr<Guid>> ExecuteAsync(LoginUserVM credentials)
    {
      if (credentials == null)
      {
        return Errors.User.InvalidCredentials;
      }

      var user = await _userRepository.GetByEmailAsync(credentials.Email);
      if (user == null)
      {
        return Errors.User.InvalidCredentials;
      }

      var passwordValid = BCrypt.Net.BCrypt.Verify(credentials.Password, user.Password);
      if (!passwordValid)
      {
        return Errors.User.InvalidCredentials;
      }

      return user.Id;
    }

  }
}
