using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI.Domain.Models.Register;

namespace WebAPI.Infrastructure.Data.Maps.Register
{
    public class PhysicalPersonMap : IEntityTypeConfiguration<PhysicalPersonModel>
    {
        public void Configure(EntityTypeBuilder<PhysicalPersonModel> builder)
        {
            builder
                .ToTable("PhysicalPersons");
            builder
                .Property(x => x.Cpf)
                .IsRequired()
                .HasMaxLength(11)
                .HasColumnType("varchar(11)");
            builder
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnType("varchar(200)");
            builder
                .HasOne(x => x.Person)
                .WithOne(x => x.PhysicalPerson)
                .HasForeignKey<PhysicalPersonModel>(x => x.Id);
                           
        }
    }
}