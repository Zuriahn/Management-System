using Microsoft.EntityFrameworkCore;
using WebApp.Entities;

namespace WebApp.EFConfiguration
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    //public DbSet<Role> Roles { get; set; }
    //public DbSet<Department> Departments { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<HistoryProduct> HistoryProducts { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

      //Relations
      
      //role
      //modelBuilder.Entity<Role>().HasMany(r => r.Users).WithOne(u => u.Role).HasForeignKey(u => u.RoleId);

      //department
      //modelBuilder.Entity<Department>().HasMany(d => d.Users).WithOne(u => u.Department).HasForeignKey(u => u.DepartmentId);

      //user
      modelBuilder.Entity<User>().HasMany(u => u.Tickets).WithOne(t => t.User).HasForeignKey(t => t.UserId);

      //product
      modelBuilder.Entity<Product>().HasMany(p => p.Tickets).WithOne(t => t.Product).HasForeignKey(t => t.ProductId);

      //category
      modelBuilder.Entity<Category>().HasMany(c => c.Products).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);

      //HistoryProduct
      modelBuilder.Entity<User>().HasMany(u => u.Products).WithMany(p => p.Users).UsingEntity<HistoryProduct>();

    }

  }
}
