using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiService
{
    public class IocConfig
    {
        public static IContainer IocContainerFactory(IServiceCollection services)
        {
            var builder = new ContainerBuilder();
            //builder.RegisterModule<DefaultModule>();
            //builder.RegisterAssemblyModules
            //builder.RegisterAssemblyTypes(typeof(App.Service.AutoMapperProfileRegister).Assembly)
            //    .Where(t => t.Name.EndsWith("Repository"))
            //    .AsImplementedInterfaces();
            builder.Populate(services);
            return builder.Build();
        }
    }
}
