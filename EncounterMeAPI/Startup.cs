using EncounterMeAPI.Persistance;
using EncounterMeAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace EncounterMeAPI
{
    public class Startup
    {
        public Startup (IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices (IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EncounterMeAPI", Version = "v1" });
            });

            var databaseString = Configuration.GetConnectionString("Database");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(databaseString, ServerVersion.AutoDetect(databaseString)));

            //Please create an interface for this
            services.AddScoped<StatisticsService>();
            services.AddScoped<IStatisticsService, StatisticsService>();
            services.AddScoped<TrailValidator>();
            services.AddScoped<ITrailService, TrailService>();
        }

        public void Configure (IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EncounterMeAPI v1"));
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
