using AlCollection.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlCollection.Data.ModelsConfigurations
{
    /// <summary>
    /// Object contains configurations for a UserFeedback table.
    /// </summary>
    public class UserFeedbackConfiguration : IEntityTypeConfiguration<UserFeedback>
    {
        public void Configure(EntityTypeBuilder<UserFeedback> builder)
        {
            #region References
            builder.HasOne(uf => uf.User)
                .WithOne()
                .HasForeignKey<User>(uf => uf.Nickname);

            builder.HasOne(uf => uf.Drink)
                .WithOne()
                .HasForeignKey<Drink>(uf => uf.DrinkName);
            #endregion

            #region Properties
            builder.Property(uf => uf.FirstComment)
                .HasColumnType("nvarchar")
                .HasColumnName("First impression")
                .HasMaxLength(1000);

            builder.Property(uf => uf.SecondComment)
                .HasColumnType("nvarchar")
                .HasColumnName("Conscious criticism")
                .HasMaxLength(1000);
            #endregion
        }
    }
}
