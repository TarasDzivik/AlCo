using AlCollection.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlCollection.Data.ModelsConfigurations
{
    /// <summary>
    /// Object contains configurations for a UserCollection table.
    /// </summary>
    public class UserCollectionConfiguration : IEntityTypeConfiguration<UserCollection>
    {
        public void Configure(EntityTypeBuilder<UserCollection> builder)
        {
            #region Properties
            builder.HasKey(u => u.Id);
            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd();
            #endregion

            #region References
            builder.HasOne(uc => uc.User)
                .WithOne(u => u.Collection);

            builder.HasMany(uc => uc.Drinks)
                .WithOne(d => d.Collection);
            #endregion
        }
    }
}
