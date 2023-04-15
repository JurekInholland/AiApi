namespace Models.Requests;

public class LoginUserRequest
{
    string UsernameOrEmail { get; set; }
    string Password { get; set; }
}
