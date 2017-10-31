﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
//using ListingTodos.Entities;
using Microsoft.EntityFrameworkCore;
//using ListingTodos.Repositories;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ListingTodos
{
    public class Startup
    {
        public static IConfigurationRoot Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            //var builder = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json");

            //Configuration = builder.Build();

            services.AddMvc();
            //services.AddDbContext<StudentContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:StudentConnection"]));
            //services.AddScoped<StudentRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
