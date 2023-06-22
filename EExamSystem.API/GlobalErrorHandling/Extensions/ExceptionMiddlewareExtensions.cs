using EExamSystem.Core.Utilities.CustomeException;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace EExamSystem.API.GlobalErrorHandling.Extensions
{
    public static class ExceptionMiddlewareExtensions
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
                        var cex = contextFeature.Error as CustomException;
                        if (cex!.StatusCode != 0)
                            context.Response.StatusCode = cex.StatusCode;
                        else
                            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                        //logger.LogError($"Something went wrong: {contextFeature.Error}");
                        await context.Response.WriteAsync(new ErrorDetails()
                        {
                            StatusCode = context.Response.StatusCode,
                            ResponseMessage = cex.ResponseMessage ?? "Something went wrong"
                        }.ToString()); ;
                    }
                });
            });
        }
    }
}
