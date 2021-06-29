using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI.Domain.Models.Security;

namespace WebAPI.Infrastructure.Data.Maps.Security
{
    public class UserMap : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.ToTable("Users");
            builder.HasKey("Id");
            builder
                .Property(x => x.UserName)
                .IsRequired()
                .HasMaxLength(50)                
                .HasColumnType("varchar(50)");
            builder 
                .Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnType("varchar(200)");
            builder
                .Property(x => x.Password)
                .IsRequired()
                .HasColumnName("nvarchar(max)");

        }
    }
}