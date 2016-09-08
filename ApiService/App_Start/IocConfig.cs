using Api.Infrastructure;
using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Threading.Tasks;

namespace ApiService
{
    public class IocConfig
    { 
        public static IContainer IocContainerFactory(IServiceCollection services, IConfigurationRoot configuration)
        {
            var builder = new ContainerBuilder();
            IConfigurationSection sectionData = configuration.GetSection("AppSetting");
            var section = new AppSetting();
            sectionData.Bind(section);
            List<Assembly> assemblyList = new List<Assembly>();
            if (section.AssemblyNames != null && section.AssemblyNames.Count > 0)
            {
                section.AssemblyNames.ForEach(x =>
                {
                    assemblyList.Add(AssemblyLoadContext.Default.LoadFromAssemblyPath(Path.Combine(AppContext.BaseDirectory, x)));
                    //assemblyList.Add(Assembly.Load(new AssemblyName(x)));
                });
                builder.RegisterAssemblyModules(assemblyList.ToArray());
            }

            //builder.RegisterInstance<string>(configuration.GetConnectionString("DefaultConnection")).Named<string>("DefaultConnection");
            builder.RegisterType<DataContext>()
                   .WithParameter("connectionString", configuration.GetConnectionString("DefaultConnection"));

            builder.Populate(services);
            return builder.Build();
        }
    }
}
