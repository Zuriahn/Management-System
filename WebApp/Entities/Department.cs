using WebApp.Common;

namespace WebApp.Entities
{
  public class Department : BaseCommon
  {
    public Department(Guid id, string name) 
    {
      Id = id; 
      Name = name;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }

    //relations
   
    //A department have many user and one user own by one department
    //public ICollection<User>? Users { get; set; } 
    
  }
}
