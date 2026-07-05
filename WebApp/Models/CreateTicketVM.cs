using WebApp.Entities;

namespace WebApp.Models
{
  public class CreateTicketVM
  {
    public CreateTicketVM(
    string title,
    string description,
    DateTime reviewDate,
    DateTime reviewAnswer,
    bool isClosed,
    Guid userId,
    Guid productId
  )
    {
      Title = title;
      Description = description;
      ReviewDate = reviewDate;
      ReviewAnswer = reviewAnswer;
      IsClosed = isClosed;
      ProductId = productId;
      UserId = userId;
    }

    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime ReviewDate { get; set; }
    public DateTime ReviewAnswer { get; set; }
    public bool IsClosed { get; set; }
    public Guid ProductId { get; set; }
    public Guid UserId { get; set; }

  }
}
