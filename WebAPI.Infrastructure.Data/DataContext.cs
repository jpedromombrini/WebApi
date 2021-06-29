using Microsoft.EntityFrameworkCore;
using WebAPI.Domain.Models.Register;
using WebAPI.Domain.Models.Security;
using WebAPI.Infrastructure.Data.Maps.Register;
using WebAPI.Infrastructure.Data.Maps.Security;

namespace WebAPI.Infrastructure.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<AddressModel> Addresses { get; set; }
        public DbSet<PhysicalPersonModel> PhysicalPersons { get; set; }      
        public DbSet<LegalPersonModel> LegalPersons { get; set; }      
        public DbSet<PersonModel> Persons { get; set; }   
        public DbSet<UserModel> Users { get; set; }
        
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AddressMap());    
            builder.ApplyConfiguration(new PersonMap());                         
            builder.ApplyConfiguration(new LegalPersonMap());
            builder.ApplyConfiguration(new PhysicalPersonMap());
            builder.ApplyConfiguration(new UserMap());
        }
    }    
}