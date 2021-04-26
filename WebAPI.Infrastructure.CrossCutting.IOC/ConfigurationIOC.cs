using Autofac;
using WebAPI.Domain.Core.Interfaces.Repositories;
using WebAPI.Domain.Core.Interfaces.Services;
using WebAPI.Domain.Services.Services;
using WebAPI.Infrastructure.Repository.Repositories;

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
                #endregion
                #region IOC Services
                builder.RegisterType<AddressService>().As<IAddressService>();
                builder.RegisterType<LegalPersonService>().As<ILegalPersonService>();
                builder.RegisterType<PhysicalPersonService>().As<IPhysicalPersonService>();
                #endregion

            #endregion
        }
    }
}