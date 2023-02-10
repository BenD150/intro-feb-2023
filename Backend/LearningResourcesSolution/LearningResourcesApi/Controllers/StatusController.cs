using LearningResourcesApi.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

namespace LearningResourcesApi.Controllers;

public class StatusController : ControllerBase
{
    private ISystemTime _systemTime;

    public StatusController(ISystemTime systemTime)
    {
        _systemTime = systemTime;
    }

    [HttpGet("/status")]
    public ActionResult GetTheStatus()
    {
        // Look this up from a database for example
        // If it is between midnight and 4PM use a phone number
        // outside of that, use an email address
        var contact = _systemTime.GetCurrent().Hour < 4 ? "bob@aol.com" : "555 555-5555";
        var response = new GetStatusResponse
        {
            Message = "All Good!",
            Contact = "555-555-5555"
        };
        return Ok(response);
    }
}


public class GetStatusResponse
{
    public string Message { get; set; } = string.Empty;
    public string Contact { get; set; } = string.Empty;
}
