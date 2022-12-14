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
            #region Properties
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id)
                .HasColumnType("nvarchar")
                .HasColumnName("Short Name")
                .HasMaxLength(56)
                .IsRequired();

            builder.Property(c => c.LongName)
                .HasColumnType("text")
                .HasColumnName("Country Name")
                .HasMaxLength(56)
                .IsRequired();
            #endregion

            #region References
            builder.HasMany(c => c.Brands)
                .WithOne(b => b.BrandCountry)
                .HasForeignKey(c => c.Id);

            builder.HasMany(c => c.Drinks)
                .WithOne(d => d.Country)
                .HasForeignKey(c => c.Id)
                .IsRequired();

            builder.HasMany(c => c.Users)
                .WithOne(u => u.Citizenship)
                .HasForeignKey(c => c.Id);
            #endregion
        }
    }
}
