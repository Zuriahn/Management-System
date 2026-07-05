using WebApp.Models;
using WebApp.UseCases.Interfaces;
using WebApp.Exceptions;
using ErrorOr;
using WebApp.Entities;
using WebApp.UseCases.UserCases.Interfaces;

namespace WebApp.UseCases.UserCases
{
  public class ViewCreateUser : IViewCreateUser
  {
    private readonly IUserRepository _userRepository;
    public ViewCreateUser(IUserRepository userRepository)
    {
      _userRepository = userRepository;
    }

    public async Task<ErrorOr<Guid>> ExecuteAsync(CreateUserVM user)
    {
      if (user == null)
      {
        return Errors.User.UserIsEmpty;
      }

      var newUser = new User(
          Guid.NewGuid(),
          user.Email,
          user.Name,
          user.LastName,
          user.Birthday,
          user.JobTitle,
          user.Role,
          user.Department
        );

      await _userRepository.AddAsync( newUser );

      await Task.Delay(1000);

      return newUser.Id;
    }

  }
}
