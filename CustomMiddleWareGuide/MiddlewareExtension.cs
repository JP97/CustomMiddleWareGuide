using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomMiddleWareGuide
{
    public static class MiddlewareExtension
    {
        public static void RunHelloWorld(this IApplicationBuilder app)
        {
            app.Run(async (Context) =>
            {
                await Context.Response.WriteAsync("Hello World!(Run)");
                
            });
        }

        public static IApplicationBuilder UseHelloWorld(this IApplicationBuilder app)
        {
            return app.UseMiddleware<HelloWorldMiddleware>();
        }

        public static IApplicationBuilder UseHelloWorldInClass(this IApplicationBuilder app)
        {
            return app.UseMiddleware<HelloWorldMiddleware>();
        }
    } 
}
