namespace WebApp.Models
{
  public class CreateProductVM
  {
    public CreateProductVM(
    string name,
    string description,
    Guid categoryId
  )
    {
      Name = name;
      Description = description;
      CategoryId = categoryId;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public Guid CategoryId { get; set; }
  }
}
