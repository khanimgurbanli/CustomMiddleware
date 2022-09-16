using Middleware.Middlewares;

namespace Middleware.Extensions
{
    public static class ApplicationExtension
    {
        public static IApplicationBuilder UseContent(this IApplicationBuilder app)
        {
            //    app.UseMiddleware<RequestMiddlware>();
            //    app.UseMiddleware<CircuitMiddleware>();
            return app.UseMiddleware<ResponseMiddleware>();
        }
    }
}
