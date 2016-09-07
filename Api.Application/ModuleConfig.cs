using Api.Interfaces;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Application
{
    public class ModuleConfig : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentApp>().As<IStudentManager>();
        }
    }
}
