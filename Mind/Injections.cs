using Microsoft.Extensions.DependencyInjection;
using Mind.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mind
{
    public class Injections
    {
        /// <summary>
        /// Add injections for all solutions
        /// </summary>
        /// <param name="services"></param>
        public static void AddTransient(ref IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>(); 
        }
    }
}
