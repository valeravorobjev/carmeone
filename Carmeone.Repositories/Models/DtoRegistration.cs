using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Carmeone.Db.Entities.Base;

namespace Carmeone.Repositories.Models;

/// <summary>
/// Данные для регистрации нового пользователя в системе
/// </summary>
public class DtoRegistration
{
    /// <summary>
    /// Электронная почта пользователя. Является логином для входа.
    /// </summary>
    [JsonPropertyName("email")]
    [Required(ErrorMessage = "Email is required.")]
    public string Email { get; set; } = null!;
    
    /// <summary>
    /// Пароль
    /// </summary>
    [JsonPropertyName("password")]
    [Required(ErrorMessage = "Password is required.")]
    public string Password { get; set; } = null!;
    
    /// <summary>
    /// Подтверждение пароля
    /// </summary>
    [JsonPropertyName("confirm_password")]
    [Required(ErrorMessage = "ConfirmPassword is required.")]
    public string ConfirmPassword { get; set; } = null!;

    /// <summary>
    /// Роль пользователя (компания или индивидуальный пользователь)
    /// </summary>
    [JsonPropertyName("account_role")]
    [Required(ErrorMessage = "AccountRole is required.")]
    public AccountRole AccountRole { get; set; }
}