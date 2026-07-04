using WebApp.Common;

namespace WebApp.Entities
{
  public class Ticket : BaseCommon
  {
    public Ticket(
      Guid id, 
      string title, 
      string description, 
      DateTime reviewDate, 
      DateTime reviewAnswer, 
      bool isClosed,
      Guid userId,
      Guid productId
      )
    {
      Id = id;
      Title = title;
      Description = description;
      ReviewDate = reviewDate;
      ReviewAnswer = reviewAnswer;
      IsClosed = isClosed;
      ProductId = productId;
      UserId = userId;
    }

    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime ReviewDate { get; set; }
    public DateTime ReviewAnswer { get; set; }
    public bool IsClosed { get; set; }

    //relations

    //Many ticket are by one product and one product can create many tickets
    public Guid ProductId { get; set; }
    public Product? Product { get; set; } 

    //Many tickets are by one user and one user can create many tickets
    public Guid UserId { get; set; }
    public User? User { get; set; }

  }
}
