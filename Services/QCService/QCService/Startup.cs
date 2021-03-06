using System.Reflection;
using IED.Server.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using QCService.Infrastructure;
using QCService.Infrastructure.Repositories;
using QCService.Infrastructure.Repositories.Imps;
using QCService.Infrastructure.Services;
using QCService.Infrastructure.Services.Imps;
using SINNIKA.Cipher;

namespace QCService
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "QCService", Version = "v1" });
            });
            AddServices(services);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()|| true)
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "QCService v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //app.SeedFakeDatabase();

        }

        private IServiceCollection AddServices(IServiceCollection services)
        {
            var secret = Assembly.GetExecutingAssembly().FullName.Split(',')[0];
            // services.AddDbContext<QCContext>(option => option.UseInMemoryDatabase("InMemory"));
            //services.AddDbContext<QCContext>(option => option.UseSqlServer(Configuration.GetConnectionString("TestConnection")));
            services.AddDbContext<QCContext>(option => option.UseSqlServer(Configuration.GetConnectionString("QCContext").Decrypt(secret)));

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            services.AddAutoMapper(typeof(MapperProfile).Assembly);
            services.AddScoped<Infrastructure.Repositories.IQCRequestRepository, Infrastructure.Repositories.Imps.QCRequestRepository>();
            services.AddScoped<IJsonRepository, JsonRepository>();

            services.AddScoped<Infrastructure.Services.IQCRequestService, Infrastructure.Services.Imps.QCRequestService>();

            // services.AddGrapQLService(_env);

            return services;
        }
    }
}
