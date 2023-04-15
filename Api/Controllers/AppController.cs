using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

/// <inheritdoc />
[Route("/")]
public class AppController : BaseController
{
    /// <summary>
    ///    Returns the index page of a SPA application
    /// </summary>
    /// <returns></returns>
    [HttpGet("{route}", Name = nameof(App))]
    public async Task<IActionResult> App()
    {
        return Ok();
    }
}
