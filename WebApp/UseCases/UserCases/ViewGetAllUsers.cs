using WebApp.UseCases.Interfaces;
using WebApp.UseCases.UserCases.Interfaces;
using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.UserCases
{
  public class ViewGetAllUsers : IViewGetAllUsers
  {
    private readonly IUserRepository _userRepository;
    public ViewGetAllUsers(IUserRepository userRepository)
    {
      _userRepository = userRepository;
    }

    public async Task<ErrorOr<List<UserVM>>> ExecuteAsync()
    {
      var users = await _userRepository.GetAllAsync();

      var userVMs = users.Select(u => new UserVM(
        u.Id,
        u.Email,
        u.Name,
        u.LastName,
        u.Birthday,
        u.JobTitle,
        u.Role,
        u.Department
      )).ToList();

      return userVMs;
    }

  }
}
