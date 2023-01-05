using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Carmeone.Repositories.Models;

/// <summary>
/// Параметры для подтверждения регистрации
/// </summary>
public class CRegistrationConfirm
{
    /// <summary>
    /// Идентификатор аккаунта
    /// </summary>
    [JsonPropertyName("account_id")]
    [Required]
    public string AccountId { get; set; }
    
    /// <summary>
    /// Идентификатор аккаунта
    /// </summary>
    [JsonPropertyName("registration_confirm_code")]
    [Required]
    public string RegistrationConfirmCode { get; set; }
}