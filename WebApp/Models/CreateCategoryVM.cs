namespace WebApp.Models
{
  public class CreateCategoryVM
  {
    public CreateCategoryVM(string name)
    {
      Name = name;
    }
    public string Name { get; set; }

  }
}
