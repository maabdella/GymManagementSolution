using GymManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagement.Configrations;

public class PlanConfigration : IEntityTypeConfiguration<Plan>
{
    public void Configure(EntityTypeBuilder<Plan> builder)
    {
        builder.Property(x => x.Name)
               .HasColumnType("varchar")
               .HasMaxLength(50);

        builder.Property(x => x.Descriptiion)
               .HasMaxLength(200);

        builder.Property(x=>x.Price)
               .HasPrecision(10, 2);

        builder.Property(x => x.CreatedAt)
               .HasDefaultValueSql("GETDATE()");

        builder.ToTable(tb =>
        {
            tb.HasCheckConstraint("CK_Plan_DurationDays", "DurationDays Between 1 and 365");
        });
    }
} 
