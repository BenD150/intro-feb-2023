using Microsoft.AspNetCore.Mvc;

namespace LearningResourcesApi.Controllers;

public class ResourcesController : ControllerBase
{
    [HttpGet("/resouces")]
    public async Task<ActionResult> GetResources()
    {
        return Ok();
    }
 }
