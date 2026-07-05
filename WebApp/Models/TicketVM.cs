namespace WebApp.Models
{
  public class TicketVM
  {
    public TicketVM(
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
      UserId = userId;
      ProductId = productId;
    }

    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime ReviewDate { get; set; }
    public DateTime ReviewAnswer { get; set; }
    public bool IsClosed { get; set; }
    public Guid UserId { get; set; }
    public Guid ProductId { get; set; }

  }
}
