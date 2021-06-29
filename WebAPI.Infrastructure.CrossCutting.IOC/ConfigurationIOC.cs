using Autofac;
using WebAPI.Domain.Core.Interfaces.Repositories.Register;
using WebAPI.Domain.Core.Interfaces.Repositories.Security;
using WebAPI.Domain.Core.Interfaces.Services.Register;
using WebAPI.Domain.Core.Interfaces.Services.Security;
using WebAPI.Domain.Services.Services.Register;
using WebAPI.Domain.Services.Services.Security;
using WebAPI.Infrastructure.Repository.Repositories.Register;
using WebAPI.Infrastructure.Repository.Repositories.Security;

namespace WebAPI.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOc

                #region IOC Repositories SQL
                builder.RegisterType<AddressRepository>().As<IAddressRepository>();
                builder.RegisterType<LegalPersonRepository>().As<ILegalPersonRepository>();
                builder.RegisterType<PhysicalPersonRepository>().As<IPhysicalPersonRepository>();
                builder.RegisterType<UserRepository>().As<IUserRepository>();
                #endregion
                #region IOC Services
                builder.RegisterType<AddressService>().As<IAddressService>();
                builder.RegisterType<LegalPersonService>().As<ILegalPersonService>();
                builder.RegisterType<PhysicalPersonService>().As<IPhysicalPersonService>();
                builder.RegisterType<UserService>().As<IUserService>();
                #endregion

            #endregion
        }
    }
}