namespace WebApp.Models
{
  public class CreateRoleVM
  {
    public CreateRoleVM(string name)
    {
      Name = name;
    }

    public string Name { get; set; }

  }
}
