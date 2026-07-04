using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp.Entities;

namespace WebApp.EFConfiguration.ModelsConfiguration
{
  public class CategoryConfiguration : IEntityTypeConfiguration<Category>
  {
    public void Configure(EntityTypeBuilder<Category> builder)
    {
      builder.ToTable("Categories");

      builder.HasKey(x => x.Id);

      builder.HasIndex(u => u.Name).IsUnique();

      builder.Property(u => u.Name).HasMaxLength(50);

    }
  }
}
