using AlCollection.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlCollection.Data.ModelsConfigurations
{
    /// <summary>
    /// Object contains configurations for a UserDrink table.
    /// </summary>
    public class UserDrinkConfiguration : IEntityTypeConfiguration<UserDrink>
    {
        public void Configure(EntityTypeBuilder<UserDrink> builder)
        {
            #region Properties
            builder.Property(ud => ud.DegustatingDay)
                .HasColumnType("Smalldatetime")
                .HasColumnName("Degustation day")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(ud => ud.AgeOfColectors)
                .HasColumnType("TINYINT")
                .HasColumnName("Degustation day")
                .IsRequired();

            builder.Property(d => d.Rating)
                .HasColumnType("FLOAT")
                .HasPrecision(1, 1)
                .HasColumnName("Rating");
            #endregion

            #region References
            builder.HasOne(ud => ud.Collection)
                .WithMany(uc => uc.Drinks); // just delegate to EF make a FK Automatically from PK (for a test)

            builder.HasOne(ud => ud.Drink)
                .WithOne()
                .HasForeignKey<Drink>(ud => ud.Id);
            #endregion
        }
    }
}
