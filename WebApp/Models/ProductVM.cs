namespace WebApp.Models
{
  public class ProductVM
  {
    public ProductVM(
      Guid id,
      string name,
      string description,
      Guid categoryId
    )
    {
      Id = id;
      Name = name;
      Description = description;
      CategoryId = categoryId;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid CategoryId { get; set; }

  }
}
