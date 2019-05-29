using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApiProject.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookApiProject
{
    public class Startup
    {
        public static IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // Using SQL \/;
            // var connectionString = Configuration["connectionStrings:bookDbConnectionString"];
            // services.AddDbContext<BookDbContext>(c => c.UseSqlServer(connectionString));
            // then add this line on appsettings.json, on "connectionStrings": "bookDbConnectionString": "Server=(localdb)\\mssqllocaldb;Database=BookApiProject;Trusted_Connection=True;"
            
            // Using Sqlite \/;
            services.AddDbContext<BookDbContext>(x => x.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<ICountryRepository, CountryRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, BookDbContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // app.Run(async (context) =>
            // {
            //     await context.Response.WriteAsync("Hello World!");
            // });

            // Uncomment the line below to seed the database;
            // context.SeedDataContext();

            app.UseMvc();
        }
    }
}
