namespace Carmeone.Services.Models;

/// <summary>
/// Настройки SMTP
/// </summary>
public class SmtpSettings
{
    /// <summary>
    /// Логин пользователя
    /// </summary>
    public string Login { get; set; } = null!;
    /// <summary>
    /// Пароль
    /// </summary>
    public string Password { get; set; } = null!;
}