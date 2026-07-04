using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp.Entities;

namespace WebApp.EFConfiguration.ModelsConfiguration
{
  public class RoleConfiguration : IEntityTypeConfiguration<Role>
  {
    public void Configure(EntityTypeBuilder<Role> builder)
    {
      builder.ToTable("Roles");

      builder.HasKey(x => x.Id);

      builder.HasIndex(u => u.Name).IsUnique();

      builder.Property(u => u.Name).HasMaxLength(50);

    }
  }
}
