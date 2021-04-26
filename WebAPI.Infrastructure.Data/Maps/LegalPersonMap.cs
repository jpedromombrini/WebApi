using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI.Domain.Models;

namespace WebAPI.Infrastructure.Data.Maps
{
   public class LegalPersonMap : IEntityTypeConfiguration<LegalPersonModel>
    {
        public void Configure(EntityTypeBuilder<LegalPersonModel> builder)
        {
            builder
                .ToTable("LegalPersons");
            builder
                .Property(x => x.CompanyName)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnType("varchar(200)");
            builder
                .Property(x => x.Cnpj)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnType("varchar(14)");
            builder
                .Property(x => x.Subscription)
                .IsRequired()
                .HasMaxLength(30)                
                .HasColumnType("varchar(20)");
            builder
                .Property(x => x.Fantasy)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar(50)");           
            builder
                .HasOne(x => x.Person)
                .WithOne(x => x.LegalPerson)
                .HasForeignKey<LegalPersonModel>(x => x.Id);               
            
        }
    }
}