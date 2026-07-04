using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApp.Entities;

namespace WebApp.EFConfiguration.ModelsConfiguration
{
  public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
  {
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
      builder.ToTable("Tickets");

      builder.HasKey(x => x.Id);

      builder.Property(u => u.Title).HasMaxLength(100);

      builder.Property(u => u.UserId).IsRequired();

      builder.Property(u => u.ProductId).IsRequired();

    }
  }
}
