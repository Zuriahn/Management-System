using WebApp.Common;

namespace WebApp.Entities
{
  public class Role : BaseCommon
  {
    public Role(Guid id, string name)
    {
      Id = id;
      Name = name;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }

    //relations

    //A one have many user and one user have one role
    //public ICollection<User>? Users { get; set; }
  }
}
