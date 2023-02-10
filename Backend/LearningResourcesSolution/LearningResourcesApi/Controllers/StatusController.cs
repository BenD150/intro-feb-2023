using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

namespace LearningResourcesApi.Controllers;

public class StatusController : ControllerBase
{
    [HttpGet("/status")]
    public ActionResult GetTheStatus()
    {
        // Look this up from a database for example
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
