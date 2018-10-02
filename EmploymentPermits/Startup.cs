#define DBMemory
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmploymentPermits
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddSession();
#if DBMemory
            services.AddDbContext<Mind.ApplicationContext>(opt =>
                opt.UseInMemoryDatabase("Recruitment"));

            services.AddMvc()
                    .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
#else
            services.AddDbContext<ApplicationContext>(options =>
                options.UseMySql(Configuration.GetConnectionString("DefaultConnection"),
                mysqlOptions =>
                {
                    mysqlOptions.ServerVersion(new Version(5, 7, 22), ServerType.MySql); // replace with your Server Version and Type
                }));
#endif

            // Injections
            services.AddTransient<Mind.Repositories.EPermitions.IIntrodutionRepository, Mind.Repositories.EPermitions.IntrodutionRepository> ();
            services.AddTransient<Mind.Repositories.EPermitions.IRegistrationDetailsRepository, Mind.Repositories.EPermitions.RegistrationDetailsRepository>();
            services.AddTransient<Mind.Repositories.EPermitions.IDetailsOfForeignNationalRepository, Mind.Repositories.EPermitions.DetailsOfForeignNationalRepository>();
            services.AddTransient<Mind.Repositories.EPermitions.IDetailsRedundancyRepository, Mind.Repositories.EPermitions.DetailsRedundancyRepository>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseSession();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

#if !DBMemory
            serviceProvider.GetService<Mind.ApplicationContext>().Database.Migrate();
#endif
        }
    }
}
