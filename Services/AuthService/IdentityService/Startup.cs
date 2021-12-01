// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityService.Infrastructure.GTAS_MENU;
using IdentityService.Infrastructure.GTAS_PERMISSION;
using IdentityService.Infrastructure.Repositories;
using IdentityService.Infrastructure.Repositories.Imps;
using IdentityService.Infrastructure.Services;
using IdentityService.Infrastructure.Services.Imps;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using SINNIKA.Cipher;
using System;
using System.Reflection;
using System.Text;

namespace IdentityService
{
    public class Startup
    {
        public IWebHostEnvironment Environment { get; }
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // uncomment, if you want to add an MVC-based UI
            services.AddControllers();

            var builder = services.AddIdentityServer(options =>
            {
                // see https://identityserver4.readthedocs.io/en/latest/topics/resources.html
                options.EmitStaticAudienceClaim = true;
            })
                .AddInMemoryIdentityResources(Config.IdentityResources)
                .AddInMemoryApiScopes(Config.ApiScopes)
                .AddInMemoryClients(Config.Clients);

            builder.AddDeveloperSigningCredential();

            #region authentication

            //var a = Configuration["Jwt:Secret"];

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Jwt:ValidIssuer"],
                    ValidAudience = Configuration["Jwt:ValidAudience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Secret"]))
                };
            });
            #endregion

            AddServices(services);
        }

        public void Configure(IApplicationBuilder app)
        {
            if (Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // uncomment if you want to add MVC
            app.UseStaticFiles();
            app.UseRouting();

            app.UseIdentityServer();

            // uncomment, if you want to add MVC
            app.UseAuthentication();
            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        
        private void AddServices(IServiceCollection services)
        {
            var secret = Assembly.GetExecutingAssembly().FullName.Split(',')[0];
            services.AddAutoMapper(typeof(MapperProfile).Assembly);

            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IRefeshTokenRepository, RefreshTokenRepository>();

            services.AddDbContext<GTAS_MENUContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("GTAS_MENUContext").Decrypt(secret)), ServiceLifetime.Scoped);

            services.AddDbContext<GTAS_PERMISSIONContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("GTAS_PERMISSIONContext").Decrypt(secret)), ServiceLifetime.Scoped);
        }
    }
}
