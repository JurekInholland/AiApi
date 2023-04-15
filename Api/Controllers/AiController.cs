using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Models.Responses;

namespace Api.Controllers;

/// <inheritdoc />
public class AiController : BaseController
{

    /// <summary>
    /// View the result of an analysed video
    /// </summary>
    /// <param name="id">The id of the job</param>
    /// <returns> AnalysisResult </returns>
    [HttpGet(nameof(Result))]
    [ProducesResponseType(typeof(AnalysisResult), (int) HttpStatusCode.OK)]
    public async Task<IActionResult> Result(Guid id)
    {
        return Ok();
    }

    /// <summary>
    /// Get the most recent results
    /// </summary>
    /// <returns></returns>
    [HttpGet(nameof(History))]
    [ProducesResponseType(typeof(AnalysisResult[]), (int) HttpStatusCode.OK)]
    public async Task<IActionResult> History()
    {
        return Ok();
    }
}
