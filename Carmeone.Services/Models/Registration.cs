using Carmeone.Db.Entities.Base;

namespace Carmeone.Services.Models;

/// <summary>
/// Данные для регистрации нового пользователя в системе
/// </summary>
public class Registration
{
    /// <summary>
    /// Электронная почта пользователя. Является логином для входа.
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// Пароль
    /// </summary>
    public string Password { get; set; } = null!;

    /// <summary>
    /// Подтверждение пароля
    /// </summary>
    public string ConfirmPassword { get; set; } = null!;

    /// <summary>
    /// Роль пользователя (компания или индивидуальный пользователь)
    /// </summary>
    public AccountRole AccountRole { get; set; }
}