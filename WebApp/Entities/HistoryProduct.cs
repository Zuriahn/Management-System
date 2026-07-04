using WebApp.Common;

namespace WebApp.Entities
{
  public class HistoryProduct : BaseCommon
  {
    public HistoryProduct(
        Guid id,
        DateTime asignedDate,
        DateTime removedDate,
        Guid userId,
        Guid productId
      ) 
    { 
      Id = id;
      AsignedDate = asignedDate;
      RemovedDate = removedDate;
      UserId = userId;
      ProductId = productId;
    }

    public Guid Id { get; set; }
    public DateTime AsignedDate { get; set; }
    public DateTime RemovedDate { get; set; }

    //relations
    public Guid UserId { get;  set; }
    public User? User { get; set; }
    public Guid ProductId { get; set; }
    public Product? Product { get; set; }

  }
}
