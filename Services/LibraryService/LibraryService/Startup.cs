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
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using SINNIKA.Cipher;
using LibraryService.Infrastructure.Repositories;
using LibraryService.Infrastructure.Repositories.Imps;

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
            .AddJwtBearer("Bearer", options =>
            {
                options.Authority = "https://localhost:5001";
                options.Audience = "library_api";
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("ApiScope", policy =>
                {
                    policy.RequireAuthenticatedUser();
                    policy.RequireClaim("scope", "library_api");
                });
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "LibraryService", Version = "v1" });
            });

            AddServices(services);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (true || env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LibraryService v1"));
            }
            app.UseCors(config =>
            {
                config.AllowAnyOrigin();
                config.AllowAnyMethod();
                config.AllowAnyHeader();
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers()
                .RequireAuthorization("ApiScope");
            });

            //app.SeedFakeDatabase();
        }

        private IServiceCollection AddServices(IServiceCollection services)
        {
            var secret = Assembly.GetExecutingAssembly().FullName.Split(',')[0];
            //services.AddDbContext<LibraryContext>(option => option.UseInMemoryDatabase("InMemory"));
            services.AddDbContext<LibraryContext>(option => option.UseSqlServer(Configuration.GetConnectionString("LibraryContext").Decrypt(secret)));

            services.AddAutoMapper(typeof(MapperProfile).Assembly);

            services.AddScoped<IZoneTypeRepository, ZoneTypeRepository>();
            services.AddScoped<IAQLRepository, AQLRepository>();
            services.AddScoped<IDefectRepository, DefectRepository>();
            services.AddScoped<IHandlerDefectRepository, HandlerDefectRepository>();
            services.AddScoped<ITimeDefectRepository, TimeDefectRepository>();

            // services.AddGrapQLService(_env);

            return services;
        }
    }
}
