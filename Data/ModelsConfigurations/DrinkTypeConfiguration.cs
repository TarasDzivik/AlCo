using AlCollection.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlCollection.Data.ModelsConfigurations
{
    /// <summary>
    /// Object contains configurations for a DrinkType table.
    /// </summary>
    public class DrinkTypeConfiguration : IEntityTypeConfiguration<DrinkType>
    {
        public void Configure(EntityTypeBuilder<DrinkType> builder)
        {
            #region Property
            builder.HasKey(dt => dt.Id);
            builder.Property(dt => dt.Id)
                .ValueGeneratedOnAdd();

            builder.Property(dt => dt.Type)
                .HasColumnType("nvarchar")
                .HasColumnName("Type of the drink")
                .HasMaxLength(20)
                .IsRequired();
            #endregion

            #region References
            builder.HasMany(dt => dt.Drinks)
                .WithOne(d => d.Type)
                .HasForeignKey(c => c.Id)
                .IsRequired();
            #endregion
        }
    }
}
