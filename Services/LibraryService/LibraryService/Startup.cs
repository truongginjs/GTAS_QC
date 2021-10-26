using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using LibraryService.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace LibraryService
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

            services.AddControllers();

            services.AddAuthentication()
            .AddJwtBearer("Bearer", config=>{
                config.Authority="https://localhost:5001";
                config.Audience="library.api";
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "LibraryService", Version = "v1" });
            });

            // services.AddDbContext<LibraryContext>(option => option.UseInMemoryDatabase("InMemory"));
            services.AddDbContext<LibraryContext>(option => option.UseSqlServer(Configuration.GetConnectionString("LibraryContext")));

            AddServices(services);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LibraryService v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.SeedFakeDatabase();

        }

        private IServiceCollection AddServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MapperProfile).Assembly);
            // services.AddScoped<ITestRepository,TestRepository>();

            // services.AddGrapQLService(_env);

            return services;
        }
    }
}