using WebApp.Common;

namespace WebApp.Entities
{
  public class Product : BaseCommon
  {
    public Product(
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
    

    //Relations

    //A product have many tickets and many tickets owns by one product
    public ICollection<Ticket>? Tickets { get; set; }

    //A product have one category and one category have many products
    public Guid CategoryId { get; set; }
    public Category? Category { get; set; }

    public ICollection<User>? Users { get; set; }

  }
}
