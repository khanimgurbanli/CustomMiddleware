//using Middleware.Models;
//using System.Text;

//namespace Middleware.Middlewares
//{
//    public class RequestMiddlware
//    {
//        private readonly RequestDelegate _next;

//        public RequestMiddlware(RequestDelegate next) =>_next = next;

//        public async Task Invoke(HttpContext context)
//        {
//            //string aboutHeader = context.Request.Headers["Authorization"];
//            if (aboutHeader != null && aboutHeader.ToLower().StartsWith("company"))
//            {
//                // Get the encoded all informations
//                var encodedInfo=aboutHeader.Split(' ', 2, StringSplitOptions.RemoveEmptyEntries)[1]?.Trim();
//                // Decode from Base64 to string
//                var decodednfo = Encoding.UTF8.GetString(Convert.FromBase64String(encodedInfo));
//                // Split all infos
//                Company company = new Company
//                {
//                    Name = decodednfo.Split(':', 2)[0].Trim(),
//                    Email = decodednfo.Split(':', 2)[1].Trim(),
//                    Phone = decodednfo.Split(':', 2)[2].Trim(),
//                    Country = decodednfo.Split(',', 2)[3].Trim(),
//                    City = decodednfo.Split(':', 2)[4].Trim(),
//                    Address = decodednfo.Split(':', 2)[5].Trim(),
//                };

//                context.Items["Check"] = company;

//                await _next.Invoke(context);
//            }
//        }
//    }
//}