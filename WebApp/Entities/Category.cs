using WebApp.Common;

namespace WebApp.Entities
{
  public class Category : BaseCommon
  {
    public Category(Guid id, string name) 
    {
      Id = id;
      Name = name;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }

    //relations

    //A category have many products and one product onwns by one category
    public ICollection<Product>? Products { get; set; }

  }
}
