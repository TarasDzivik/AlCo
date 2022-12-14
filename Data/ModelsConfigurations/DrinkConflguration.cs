using AlCollection.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlCollection.Data.ModelsConfigurations
{
    /// <summary>
    /// Object contains configurations for a Drink table.
    /// </summary>
    public class DrinkConflguration : IEntityTypeConfiguration<Drink>
    {
        public void Configure(EntityTypeBuilder<Drink> builder)
        {
            #region Properties
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd();

            builder.Property(d => d.DrinkName)
                .HasColumnType("nvarchar")
                .HasColumnName("Drink name")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(d => d.ABV)
                .HasColumnType("FLOAT")
                .HasPrecision(2, 2)
                .HasColumnName("Percent of alcohol")
                .HasMaxLength(4);

            builder.Property(d => d.Rating)
                .HasColumnType("Double")
                .HasPrecision(1, 1)
                .HasColumnName("Rating");
            #endregion
            #region References
            builder.HasOne(d => d.BrandName)
                .WithMany(b => b.Drinks)
                .HasForeignKey(d => d.Id);

            builder.HasOne(d => d.Type)
                .WithMany(t => t.Drinks)
                .HasForeignKey(d => d.Id);

            builder.HasOne(d => d.Country)
                .WithMany(c => c.Drinks)
                .HasForeignKey(d => d.Id)
                .IsRequired();

            builder.HasMany(d => d.Feedbacks)
                .WithOne(fb => fb.Drink)
                .HasForeignKey(d => d.User.Id);
            #endregion
        }
    }
}
