using AlCollection.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlCollection.Data.ModelsConfigurations
{
    /// <summary>
    /// Object contains configurations for a Brand table.
    /// </summary>
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd();

            builder.Property(b => b.BrandName)
                .HasColumnType("text")
                .HasColumnName("Brand name")
                .HasMaxLength(80)
                .IsUnicode(true);

            builder.HasMany(d => d.Drinks)
                .WithOne(b => b.BrandName)
                .HasForeignKey(d => d.DrinkName);

            builder.HasOne(b => b.BrandCountry)
                .WithMany(c => c.Brands)
                .HasForeignKey(b => b.Id);
        }
    }
}
