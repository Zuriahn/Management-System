using WebApp.Common;

namespace WebApp.Entities
{
  public class User : BaseCommon
  {
    public User(
        Guid id,
        string email,
        string name,
        string lastName,
        DateOnly birthday,
        string jobTitle,
        string role,
        string department
      ) 
    {
      Id = id;
      Email = email;
      Name = name;
      LastName = lastName;
      Birthday = birthday;
      JobTitle = jobTitle;
      Role = role;
      Department = department;
    }

    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateOnly Birthday { get; set; }
    public string JobTitle { get; set; }
    public string Role { get; set; }
    public string Department { get; set; }

    //relations

    //An user can registered many tickets and many tickets owns by one user
    public ICollection<Ticket>? Tickets { get; set; }

    public ICollection<Product>? Products { get; set; }

    //An user has one role but many roles are in many users
    //public Guid RoleId { get; set; }
    //public Role? Role { get; set; }

    //Many users are in one department and one department have many users
    //public Guid DepartmentId { get; set; }
    //public Department? Department { get; set; }

  }
}
