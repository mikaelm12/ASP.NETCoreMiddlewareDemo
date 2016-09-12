using Microsoft.AspNetCore.Builder;
using Middleware.Auth;

namespace Middleware.Extensions{
    public static class AuthMiddlewareExtensions{
        public static IApplicationBuilder UseAuthMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthMiddleware>();
        }
    }
}