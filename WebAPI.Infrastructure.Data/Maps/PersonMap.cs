using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI.Domain.Models;

namespace WebAPI.Infrastructure.Data.Maps
{
    public class PersonMap : IEntityTypeConfiguration<PersonModel>
    {
        public void Configure(EntityTypeBuilder<PersonModel> builder)
        {
            builder
                .ToTable("Persons");                
            builder
                .HasKey("Id");
            builder
                .Property(x => x.Email)                
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnType("varchar(200)");
            builder
                .Property(x => x.PersonType)
                .IsRequired();     
            builder
                .Property(x => x.Phone)
                .IsRequired()                
                .HasMaxLength(11)
                .HasColumnType("varchar(11)");
            builder
                .Property(x => x.Observation)
                .HasMaxLength(200)
                .HasColumnType("varchar(200)");
            builder
                .HasOne(x => x.Address)
                .WithOne(y => y.Person)
                .HasForeignKey<AddressModel>(f => f.PersonId);                
        }
    }
}