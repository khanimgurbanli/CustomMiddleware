//namespace Middleware.Middlewares
//{
//    public class ContentMiddleware
//    {
//        private readonly RequestDelegate _next;

//        public ContentMiddleware(RequestDelegate requestDelegate)
//        {
//            _next = requestDelegate;
//        }

//        public async Task Invoke(HttpContext context)
//        {
//            await _next.Invoke(context);
//            if (context.Request.Path.Value?.T=null )
//            {
//                await context.Response.WriteAsync($"Response succesfully filtered");
//            }
//        }
//    }
//}
