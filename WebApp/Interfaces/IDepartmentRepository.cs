using WebApp.Entities;

namespace WebApp.Interfaces
{
  public interface IDepartmentRepository
  {
    public Task AddAsync(Department department);

    public void Update(Department department);

    public void Disabled(Department department);

    public Task<Department?> GetByIdAsync(Guid id);
    public Task<List<Department>> GetAllAsync();

  }
}
