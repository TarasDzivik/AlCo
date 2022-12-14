using AlCollection.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlCollection.Data.ModelsConfigurations
{
    /// <summary>
    /// Object contains configurations for a User table.
    /// </summary>
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            #region Properties
            builder.HasKey(u => u.Id);
            builder.Property(b => b.Id)
                .ValueGeneratedOnAdd();

            builder.Property(u => u.Email)
                .HasColumnType("varchar")
                .HasColumnName("Email")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(u => u.Nickname)
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                .HasColumnName("User")
                .IsRequired();

            builder.Property(u => u.DateOfBirthday)
                .HasColumnType("Smalldatetime")
                .HasColumnName("Birthday")
                .IsRequired();

            builder.Property(u => u.Gender)
                .HasColumnType("varchar")
                .HasColumnName("Gender")
                .HasMaxLength(6);

            builder.Property(u => u.FirstName)
                .HasColumnType("nvarchar")
                .HasColumnName("First name")
                .HasMaxLength(30);

            builder.Property(u => u.SecondName)
                .HasColumnType("nvarchar")
                .HasColumnName("Second name")
                .HasMaxLength(30);
            #endregion

            #region References
            builder.HasOne(u => u.Citizenship)
                .WithMany(c => c.Users)
                .HasForeignKey(u => u.Id);

            builder.HasOne(u => u.Collection)
                .WithOne(uc => uc.User)
                .HasForeignKey<UserCollection>(ul => ul.Id);
            #endregion
        }
    }
}
