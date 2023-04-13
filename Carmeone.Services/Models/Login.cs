namespace Carmeone.Services.Models;

/// <summary>
/// Логин
/// </summary>
public class Login
{
    /// <summary>
    /// Электронная почта
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// Пароль
    /// </summary>
    public string Password { get; set; } = null!;
}