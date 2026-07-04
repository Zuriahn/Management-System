using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp.Entities;

namespace WebApp.EFConfiguration.ModelsConfiguration
{
  public class DeparmentConfiguration : IEntityTypeConfiguration<Department>
  {
    public void Configure(EntityTypeBuilder<Department> builder)
    {
      builder.ToTable("Departments");

      builder.HasKey(x => x.Id);

      builder.HasIndex(u => u.Name).IsUnique();

      builder.Property(u => u.Name).HasMaxLength(50);

    }
  }
}
