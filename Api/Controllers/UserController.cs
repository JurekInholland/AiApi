using Microsoft.AspNetCore.Mvc;
using Models.Requests;

namespace Api.Controllers;

/// <inheritdoc />
public class UserController : BaseController
{
    /// <summary>
    /// Create a new user
    /// </summary>
    /// <param name="request">User request data</param>
    [HttpPost(nameof(Register))]
    public async Task<IActionResult> Register([FromBody] RegisterUserRequest request)
    {
        return Ok();
    }

    /// <summary>
    /// Login an existing user
    /// </summary>
    /// <param name="request">Login request data</param>
    [HttpPost(nameof(Login))]
    public async Task<IActionResult> Login([FromBody] LoginUserRequest request)
    {
        return Ok();
    }

    /// <summary>
    /// Clear the current user's session
    /// </summary>
    [HttpGet(nameof(LogOut))]
    public async Task<IActionResult> LogOut()
    {
        return Ok();
    }
}
