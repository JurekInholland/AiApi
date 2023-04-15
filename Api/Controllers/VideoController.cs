using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class VideoController : BaseController
{
    /// <summary>
    /// Upload a video for AI processing
    /// </summary>
    /// <param name="file">video file to analyse</param>
    /// <returns>GUID id</returns>
    [HttpPost(nameof(Upload))]
    public async Task<IActionResult> Upload([FromForm] IFormFile file)
    {
        return Ok();
    }
}
