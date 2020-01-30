using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ShortLink.Core.Contracts;
using ShortLink.Core.Contracts.Common;
using ShortLink.Core.Contracts.Links;
using ShortLink.DAL.EF.Common;
using ShortLink.DAL.EF.Links;
using ShortLink.Services.ApplicationService.Links;

namespace ShortLink.UI.MVC
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<LinkDbContext>();

            services.AddScoped<ILinkRepository, EFLinkRepository>(); 
            services.AddScoped<ILinkService, LinkService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(route =>
              //routs.MapRoute("ShortText", "/{Shorttext}", defaults: new { controller = "Link", action = "index" });
               route.MapRoute("default", "/{Controller=Home}/{Action=Index}/{Id?}"));
        }
    }
}
