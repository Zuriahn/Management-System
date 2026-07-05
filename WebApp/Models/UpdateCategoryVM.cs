namespace WebApp.Models
{
  public class UpdateCategoryVM
  {
    public UpdateCategoryVM(string name)
    {
      Name = name;
    }

    public string Name { get; set; }

  }
}
