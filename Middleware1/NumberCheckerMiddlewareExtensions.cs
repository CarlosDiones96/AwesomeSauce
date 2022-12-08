using Microsoft.AspNetCore.Builder;

namespace Middleware1
{
    public static class NumberCheckerMiddlewareExtensions
    {
        public static IApplicationBuilder UseNumberChecker(this IApplicationBuilder app )
        {
            return app.UseMiddleware<NumberCheckerMiddleware>();
        }
    }
}
