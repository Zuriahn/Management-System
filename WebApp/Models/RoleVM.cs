namespace WebApp.Models
{
  public class RoleVM
  {
    public RoleVM(Guid id, string name)
    {
      Id = id;
      Name = name;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }

  }
}
