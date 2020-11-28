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

namespace App {
  public class Startup {
    public void ConfigureServices(IServiceCollection services) {}

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
      if (env.IsDevelopment()) {
        app.UseDeveloperExceptionPage();
      }

      
      Console.WriteLine("hi");

      app.Run(async(ctx) =>{
        var req = ctx.Request;
        var res = ctx.Response;

        Console.WriteLine($"Path:{req.Path}");
 
   
        if (req.Path.ToString().Equals("/login/login.php")) {
          var user = req.Form["user"];
          var pass = req.Form["pass"];
          Console.WriteLine($"User [{user}] tried to login in with password [{pass}]...");

          //res.Cookies.Append("sid", "3333", new Microsoft.AspNetCore.Http.CookieOptions() {
          //  Path = "/"
         // });
        await res.WriteAsync("k");
        }

        if (req.Path.ToString().Equals("/login/joinserver.php")) {
          var user = req.Form["user"];
          var pass = req.Form["pass"];
          Console.WriteLine($"User [{user}] tried to login into a server");

          //res.Cookies.Append("sid", "3333", new Microsoft.AspNetCore.Http.CookieOptions() {
          //  Path = "/"
         // });
        await res.WriteAsync("k");
        }
   
        if (req.Path.ToString().Equals("/login/regserver.php")) {
          var user = req.Form["user"];
          var pass = req.Form["pass"];
          Console.WriteLine($"User [{user}] tried to register into a server");

          //res.Cookies.Append("sid", "3333", new Microsoft.AspNetCore.Http.CookieOptions() {
          //  Path = "/"
         // });
        await res.WriteAsync("k");
        }

        if (req.Path.ToString().Equals("/login/servers.php")) {
          var user = req.Form["user"];
          var pass = req.Form["pass"];
          Console.WriteLine($"User [{user}] tried to register into a server");

          //res.Cookies.Append("sid", "3333", new Microsoft.AspNetCore.Http.CookieOptions() {
          //  Path = "/"
         // });
        await res.WriteAsync("[t]");
        }
        
        return;
        //await context.Response.WriteAsync("Hello Glitch!!! You're running .NET Core 2.1");
      });
    }
  }
}