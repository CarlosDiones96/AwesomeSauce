using Microsoft.AspNetCore.Builder;

namespace Middleware1
{
    public static class UpperValueMiddlewareExtensions
    {
        public static IApplicationBuilder UseUpperValue(this IApplicationBuilder app)
        {
            return app.UseMiddleware<UpperValueMiddleware>();
        }
    }
}
