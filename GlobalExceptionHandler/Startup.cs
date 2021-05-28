using GlobalExceptionHandler.Controllers;
using JsonApiSerializer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.ObjectPool;
using Newtonsoft.Json;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalExceptionHandler
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
            services.AddControllers()
                .AddNewtonsoftJson();

            services.AddOptions<MvcOptions>()
                .Configure<ILoggerFactory, ObjectPoolProvider>((options, loggerFactory, objectPoolProvider) =>
                {
                    JsonApiSerializerSettings serializerSettings = new JsonApiSerializerSettings()
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    };

                    MvcNewtonsoftJsonOptions jsonOptions = new MvcNewtonsoftJsonOptions();

                    NewtonsoftJsonOutputFormatter jsonApiOutputFormatter = new NewtonsoftJsonOutputFormatter(serializerSettings, ArrayPool<Char>.Shared, options);
                    options.OutputFormatters.RemoveType<NewtonsoftJsonOutputFormatter>();
                    options.OutputFormatters.Add(jsonApiOutputFormatter);

                    NewtonsoftJsonInputFormatter jsonApiInputFormatter = new NewtonsoftJsonInputFormatter(loggerFactory.CreateLogger<NewtonsoftJsonInputFormatter>(), serializerSettings, ArrayPool<Char>.Shared, objectPoolProvider, options, jsonOptions);
                    options.InputFormatters.RemoveType<NewtonsoftJsonInputFormatter>();
                    options.InputFormatters.Add(jsonApiInputFormatter);
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
                app.UseExceptionHandler("/error");
            }
            else
            {
                app.UseExceptionHandler("/error");
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
