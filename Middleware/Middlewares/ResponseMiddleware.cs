using Microsoft.Extensions.Configuration;
using Middleware.Models;
using System.Collections.Generic;
using System.Globalization;

namespace Middleware.Middlewares
{
    public class ResponseMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _configuration;


        public ResponseMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _configuration = configuration;
        }

        public async Task Invoke(HttpContext context)
        {
            //request
            await _next.Invoke(context);


            Dictionary<string, string> data = _configuration.GetSection("CompanyInfo")
                                                            .GetChildren()
                                                            .ToDictionary(x => x.Key, x => x.Value);
            context.Response.OnStarting(state =>
           {
               foreach (var keyValue in data)
               {
                   context.Response.Headers.Add(keyValue.Key, keyValue.Value);
               }
               return Task.CompletedTask;
           }, context);
        }
    }
}
