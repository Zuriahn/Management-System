using ErrorOr;
using WebApp.Models;

namespace WebApp.UseCases.UserCases.Interfaces
{
  public interface IViewGetAllUsers
  {
    public Task ExecuteAsync();
  }
}
