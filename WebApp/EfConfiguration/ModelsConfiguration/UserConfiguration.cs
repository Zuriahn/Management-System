using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp.Entities;

namespace WebApp.EFConfiguration.ModelsConfiguration
{
  public class UserConfiguration : IEntityTypeConfiguration<User>
  {
    public void Configure(EntityTypeBuilder<User> builder)
    {
      builder.ToTable("Users");

      builder.HasKey(x => x.Id);

      builder.HasIndex(u => u.Email).IsUnique();

      builder.Property(u => u.Email).HasMaxLength(50);

      builder.Property(u => u.Name).HasMaxLength(50);

      builder.Property(u => u.LastName).HasMaxLength(50);

      builder.Property(u => u.JobTitle).HasMaxLength(50);

      //builder.Property(u => u.RoleId).IsRequired();

      //builder.Property(u => u.DepartmentId).IsRequired();

    }
  }
}
