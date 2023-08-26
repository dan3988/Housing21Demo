using System.Diagnostics;
using System.Net;

using Demo.Website.Exceptions;

using FluentValidation;
using FluentValidation.Results;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Demo.Website.Filters;

public class ApiExceptionFilterAttribute : ExceptionFilterAttribute
{
    public ApiExceptionFilterAttribute()
    {
    }

    public override void OnException(ExceptionContext context)
    {
        switch (context.Exception)
        {
            case NotFoundException:
                HandleNotFoundException(context);
                break;
            case ValidationException ex:
                HandleValidationException(context, ex.Errors);
                break;
            default:
                HandleUnhandledException(context);
                break;
        }
    }

    private static void HandleUnhandledException(ExceptionContext context)
    {
        var details = new HttpValidationProblemDetails
        {
#if DEBUG
            Detail = context.Exception.ToString(),
#endif
            Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.6.1",
            Title = "An unknown error occured while processing your request"
        };

        if (Debugger.IsAttached)
            Debugger.Break();

        var factory = context.HttpContext.RequestServices.GetRequiredService<ILoggerFactory>();
        var loggerType = context.ActionDescriptor is ControllerActionDescriptor c ? c.ControllerTypeInfo : typeof(ApiExceptionFilterAttribute);
        var logger = factory.CreateLogger(loggerType);

        logger.LogError("Unhandled exception in request: {exception}", context.Exception);

        context.ExceptionHandled = true;
        context.Result = new ObjectResult(details)
        {
            StatusCode = (int)HttpStatusCode.InternalServerError
        };
    }

    private static void HandleNotFoundException(ExceptionContext context)
    {
        var details = new HttpValidationProblemDetails
        {
            Title = "The specified item was not found",
            Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.4",
            Detail = context.Exception.Message
        };

        context.ExceptionHandled = true;
        context.Result = new NotFoundObjectResult(details);
    }

    private static void HandleValidationException(ExceptionContext context, IEnumerable<ValidationFailure> errors)
    {
        var details = new HttpValidationProblemDetails
        {
            Title = "One or more validation errors occured.",
            Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.1"
        };

        foreach (var group in errors.GroupBy(v => v.PropertyName))
        {
            var messages = group.Select(v => v.ErrorMessage).ToArray();
            details.Errors.Add(group.Key, messages);
        }

        context.ExceptionHandled = true;
        context.Result = new NotFoundObjectResult(details);
    }
}
