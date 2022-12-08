using Microsoft.AspNetCore.Builder;

namespace Middleware1
{
    public static class SkipAppMiddlewareExtensions
    {
        public static IApplicationBuilder UseSkipApp(this IApplicationBuilder app)
        {
            return app.UseMiddleware<SkipAppMiddleware>();
        }
    }
}
