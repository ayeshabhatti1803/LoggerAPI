using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using System.Net;
using logger.Response;

namespace LoggerAPI.Middlewere
{
    public static class GlobalExceptionHandler
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        await context.Response.WriteAsync(new ErrorResponse ()
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = $"Internal Server Error : {contextFeature.Error.Message}"
                        }.ToString());
                    }
                });
            });
        }
    }
}
