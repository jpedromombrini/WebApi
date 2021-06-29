using System;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace WebAPI.Presentation.Middlewares
{
    public class GlobalExceptionMiddleware : IMiddleware
    {
        private readonly ILogger<GlobalExceptionMiddleware> _logger;
        private readonly IMediator _mediator;
        public GlobalExceptionMiddleware(ILogger<GlobalExceptionMiddleware> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch(Exception ex)
            {
                _logger.LogError($"Unexpected error: {ex}");
                await HandleExceptionAsync(context, ex, _mediator);
                throw ex;                
            }
        }
        private static async Task<Task> HandleExceptionAsync(HttpContext context, Exception exception, IMediator mediator)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var json = new 
            {
                context.Response.StatusCode,
                Message = "An error occured whilst processing request",
                Detailed = exception
            };
            return context.Response.WriteAsync(Newtonsoft.Json.JsonConvert.SerializeObject(json));
        }
    }
    public static class GlobalExceptionHandlerMiddlewareExtensions
    {
        public static IServiceCollection AddGlobalExceptionHandlerMiddleware(this IServiceCollection services)
        {
            return services.AddTransient<GlobalExceptionMiddleware>();
        }
        public static void UseGlobalExceptionHandlerMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<GlobalExceptionMiddleware>();
        }
    }
}