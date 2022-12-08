using Microsoft.AspNetCore.Builder;

namespace Middleware1
{
    public static class VowelMaskerMiddlewareExtensions
    {
        public static IApplicationBuilder UseVowelMasker(this IApplicationBuilder app)
        {
            return app.UseMiddleware<VowelMaskerMiddleware>();
        }
    }
}
