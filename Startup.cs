using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
          
            Console.WriteLine("hi");

            app.Run(async (ctx) =>
            {
              var req = ctx.Request;
              var res = ctx.Response;
              
              if(req.Path.ToString().StartsWith("/login"))
                {
                  var user = req.Form["user"];
                  var pass = req.Form["pass"];
                    Console.WriteLine($"User [{user}] tried to login in with password [{pass}]...");
                }
              
              Console.WriteLine(req.Path);
              await res.WriteAsync("yes");
                //await context.Response.WriteAsync("Hello Glitch!!! You're running .NET Core 2.1");
            });
        }
    }
}
