using WebApp.UseCases.Interfaces;
using WebApp.UseCases.UserCases.Interfaces;
using WebApp.Exceptions;
using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.UserCases
{
  public class ViewUpdateUser : IViewUpdateUser
  {
    private readonly IUserRepository _userRepository;
    public ViewUpdateUser(IUserRepository userRepository)
    {
      _userRepository = userRepository;
    }

    public async Task<ErrorOr<Guid>> ExecuteAsync(Guid userId, UpdateUserVM user)
    {
      if (user == null)
      {
        return Errors.User.UserIsEmpty;
      }

      var existingUser = await _userRepository.GetByIdAsync(userId);
      if (existingUser == null)
      {
        return Errors.User.NotFound;
      }

      existingUser.Email = user.Email;
      existingUser.Name = user.Name;
      existingUser.LastName = user.LastName;
      existingUser.Birthday = user.Birthday;
      existingUser.JobTitle = user.JobTitle;
      existingUser.Role = user.Role;
      existingUser.Department = user.Department;

      _userRepository.Update(existingUser);

      return existingUser.Id;
    }

  }
}
