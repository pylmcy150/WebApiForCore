using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Api.Domain
{
    public class AutoMapperProfileRegister
    {
        public static void Register()
        {
            Mapper.Initialize(x => 
            {
                x.AddProfiles(typeof(AutoMapperProfileRegister));
            });
            Mapper.AssertConfigurationIsValid();
        }
    }
}
