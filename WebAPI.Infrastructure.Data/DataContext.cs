using Microsoft.EntityFrameworkCore;
using WebAPI.Domain.Models;
using WebAPI.Infrastructure.Data.Maps;

namespace WebAPI.Infrastructure.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<AddressModel> Addresses { get; set; }
        public DbSet<PhysicalPersonModel> PhysicalPersons { get; set; }      
        public DbSet<LegalPersonModel> LegalPersons { get; set; }      
        public DbSet<PersonModel> Persons { get; set; }   
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AddressMap());    
            builder.ApplyConfiguration(new PersonMap());                         
            builder.ApplyConfiguration(new LegalPersonMap());
            builder.ApplyConfiguration(new PhysicalPersonMap());

        }
    }    
}