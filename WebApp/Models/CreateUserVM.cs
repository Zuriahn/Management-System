using WebApp.Common;

namespace WebApp.Models
{
  public class CreateUserVM
  {
    public CreateUserVM(
    string email,
    string name,
    string lastName,
    DateOnly birthday,
    string jobTitle,
    string role,
    string department
  )
    {
      Email = email;
      Name = name;
      LastName = lastName;
      Birthday = birthday;
      JobTitle = jobTitle;
      Role = role;
      Department = department;
    }

    public string Email { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateOnly Birthday { get; set; }
    public string JobTitle { get; set; }
    public string Role { get; set; }
    public string Department { get; set; }

  }
}
