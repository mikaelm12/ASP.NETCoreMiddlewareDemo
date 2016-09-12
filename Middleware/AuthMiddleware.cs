using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Middleware.Auth
{
    public class AuthMiddleware
    {
        private readonly RequestDelegate _next;
        public AuthMiddleware(RequestDelegate next){
            _next = next;
        }
        public async Task Invoke(HttpContext context){
            if(context.Request.Headers.ContainsKey("X-Authorized")){
                if(context.Request.Headers["X-Authorized"].Equals("false")){
                    context.Response.StatusCode = 401;
                    return;
                }
            }
            await _next.Invoke(context);
        }
    }
}