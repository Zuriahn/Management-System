namespace WebApp.Models
{
  public class LoginUserVM
  {
    public LoginUserVM(string email, string password)
    {
      Email = email;
      Password = password;
    }

    public string Email { get; set; }
    public string Password { get; set; }

  }
}
