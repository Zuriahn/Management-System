using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp.Entities;

namespace WebApp.EFConfiguration.ModelsConfiguration
{
  public class ProductConfiguration : IEntityTypeConfiguration<Product>
  {
    public void Configure(EntityTypeBuilder<Product> builder)
    {
      builder.ToTable("Products");

      builder.HasKey(x => x.Id);

      builder.Property(p => p.Name).HasMaxLength(75);

      builder.Property(p => p.Description).HasMaxLength(250);

      builder.Property(p => p.CategoryId).IsRequired();

    }
  }
}
