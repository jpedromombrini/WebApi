using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI.Domain.Models.Register;

namespace WebAPI.Infrastructure.Data.Maps.Register
{
    public class AddressMap : IEntityTypeConfiguration<AddressModel>
    {
        public void Configure(EntityTypeBuilder<AddressModel> builder)
        {
            builder.ToTable("Addresses");
            builder.HasKey("Id");
            builder.Property(x => x.ZipCode)
                .IsRequired()
                .HasMaxLength(9)
                .HasColumnType("varchar(9)");

            builder.Property(x => x.PublicPlace)
                .IsRequired()
                .HasMaxLength(120)
                .HasColumnType("varchar(120)");

            builder.Property(x => x.Neighborhood)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnType("varchar(60)");

            builder.Property(x => x.City)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnType("varchar(60)");
            builder
                .Property(x => x.State)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnType("varchar(60)");
        }        
    }
}