using MappingBetweenLayers.Core.SampleDomain.BusinessObjects;
using MappingBetweenLayers.Core.SampleDomain.DataAccessObjects;
using MappingBetweenLayers.Services.External;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MappingBetweenLayers
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
            services.AddHttpClient<IExternalService, ExternalService>(options =>
            {
                options.BaseAddress = new Uri("<InsertBaseAddressHere>");
            });

            services.AddScoped<IDataAccessObject, DataAccessObject>();
            services.AddScoped<IBusinessObject, BusinessObject>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
