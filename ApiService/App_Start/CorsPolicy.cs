using Microsoft.AspNetCore.Cors.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiService
{
    public class CorsPolicy
    {
        /// <summary>
        /// 允许所有域访问
        /// </summary>
        public const string ALLOWSPECIFICORIGIN = "AllowSpecificOrigin";

        public static Action<CorsOptions> RegisterAllowSpecificOrigin()
        {
            return options =>
            {
                options.AddPolicy(ALLOWSPECIFICORIGIN,
                    b =>
                    {
                        b.AllowAnyHeader();
                        b.AllowAnyMethod();
                        b.AllowAnyOrigin();
                        b.AllowCredentials();
                    });
            };
        }
    }
}
