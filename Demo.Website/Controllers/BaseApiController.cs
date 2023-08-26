using Demo.Website.Filters;

using Microsoft.AspNetCore.Mvc;

namespace Demo.Website.Controllers;

/// <summary>
/// Base class for controllers returning / ingesting raw data with helper methods for MediatR
/// </summary>
[Route("/api/[controller]")]
[ApiExceptionFilter]
public class BaseApiController : ControllerBase
{
    protected ILogger Logger { get; }

    protected BaseApiController(ILogger logger)
    {
        Logger = logger;
    }
}
