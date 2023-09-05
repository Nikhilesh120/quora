using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace SecuringWebApiUsingApiKey.Middleware
{
    public class ApiKeyMiddleware
    {
        private readonly RequestDelegate _next;
        private const string APIKEYNAME = "X-API-KEY";
        public ApiKeyMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine(Environment.GetEnvironmentVariable("PROFILE_NAME"));
            if (!context.Request.Headers.TryGetValue(APIKEYNAME, out var extractedApiKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Api Key was not provided. (Using ApiKeyMiddleware) ");
                return;
            }

            var appSettings = context.RequestServices.GetRequiredService<IConfiguration>();

            var apiKey = Environment.GetEnvironmentVariable("API_KEY");

            if (!apiKey.Equals(extractedApiKey))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Unauthorized client. (Using ApiKeyMiddleware)");
                return;
            }

            await _next(context);
        }
    }
}