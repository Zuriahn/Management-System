namespace WebApp.Models
{
  public class CategoryVM
  {
    public CategoryVM(Guid id, string name)
    {
      Id = id;
      Name = name;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }

  }
}
