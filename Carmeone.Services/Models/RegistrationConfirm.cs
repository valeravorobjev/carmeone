namespace Carmeone.Services.Models;

/// <summary>
/// Параметры для подтверждения регистрации
/// </summary>
public class RegistrationConfirm
{
    /// <summary>
    /// Идентификатор аккаунта
    /// </summary>
    public Guid AccountId { get; set; }
    
    /// <summary>
    /// Идентификатор аккаунта
    /// </summary>
    public Guid ActivationCode { get; set; }
}