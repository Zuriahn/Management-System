using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp.Entities;

namespace WebApp.EFConfiguration.ModelsConfiguration
{
  public class HistoryProductConfiguration : IEntityTypeConfiguration<HistoryProduct>
  {
    public void Configure(EntityTypeBuilder<HistoryProduct> builder)
    {
      builder.ToTable("HistoryProducts");

      builder.HasKey(x => x.Id);

    }
  }
}
