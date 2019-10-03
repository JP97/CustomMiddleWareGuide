using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CustomMiddleWareGuide
{
    public class HelloWorldMiddleware
    {
        private readonly RequestDelegate next;
        public HelloWorldMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync("Hello World! (Use in Class)\n");
            await this.next(context);
        }
    }
}
