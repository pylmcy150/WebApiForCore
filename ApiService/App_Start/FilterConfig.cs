using ApiService.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiService
{
    public class FilterConfig
    {
        public static Action<MvcOptions> RegisterGlobalOptions()
        {
            return options =>
            {
                options.Filters.Add(typeof(DefaultExceptionFilter)); // by type
                options.Filters.Add(typeof(LogErrorFilter));
            };
        }
    }
}
