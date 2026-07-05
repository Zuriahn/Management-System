namespace WebApp.Models
{
  public class UpdateTicketVM
  {
    public UpdateTicketVM(
      string title,
      string description,
      DateTime reviewDate,
      DateTime reviewAnswer,
      bool isClosed,
      Guid productId
    )
    {
      Title = title;
      Description = description;
      ReviewDate = reviewDate;
      ReviewAnswer = reviewAnswer;
      IsClosed = isClosed;
      ProductId = productId;
    }

    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime ReviewDate { get; set; }
    public DateTime ReviewAnswer { get; set; }
    public bool IsClosed { get; set; }
    public Guid ProductId { get; set; }

  }
}
