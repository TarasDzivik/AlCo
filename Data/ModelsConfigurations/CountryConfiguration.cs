using AlCollection.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlCollection.Data.ModelsConfigurations
{
    /// <summary>
    /// Object contains configurations for a Brand table.
    /// </summary>
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnType("text")
                .HasColumnName("Short Name")
                .HasMaxLength(56)
                .IsRequired();

            builder.Property(c => c.LongName)
                .HasColumnType("text")
                .HasColumnName("Country Name")
                .HasMaxLength(56)
                .IsRequired();

            builder.HasMany(c => c.Brands)
                .WithOne(b => b.BrandCountry)
                .HasForeignKey(c => c.Id);

            builder.HasMany(c => c.Drinks)
                .WithOne(d => d.Country)
                .HasForeignKey(c => c.Id)
                .IsRequired();
        }
    }
}
