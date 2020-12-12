using fiefapp.graphql;
using fiefapp.mongodb;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;

namespace fiefapp.api
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
            services.AddCors(options =>
            {
                options.AddPolicy("DefaultPolicy", builder =>
                {
                    builder.AllowAnyHeader()
                           .WithMethods("POST")
                           .WithOrigins("http://localhost:8080");
                });
            });

            services.AddHttpContextAccessor();

            services.DI_GraphQL();
            services.DI_MongoDB(Configuration);

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
                    {
                        var authority = $"https://securetoken.google.com/fiefapp-35d5e";
                        var audience = "fiefapp-35d5e";

                        options.Audience = audience;
                        options.Authority = authority;
                        options.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateIssuer = true,
                            ValidIssuer = authority,
                            ValidateAudience = true,
                            ValidAudience = audience,
                            ValidateLifetime = true
                        };
                    });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("DefaultPolicy");

            app.UseRouting();
            app.UseAuthentication();

            app.DI_UseGraphQL();
        }
    }
}
