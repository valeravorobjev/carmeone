using Carmeone.Repositories.Models;

namespace Carmeone.Repositories.Contracts;

/// <summary>
/// Работа с аккаунтом пользователя
/// </summary>
public interface IAccountRepository
{
    /// <summary>
    /// Регистрация нового пользователя
    /// </summary>
    /// <param name="registration">Регистрация</param>
    /// <returns></returns>
    ValueTask<CResult<string>> RegistrationAsync(CRegistration registration);

    /// <summary>
    /// Подтвердение регистрации пользователя
    /// </summary>
    /// <param name="registrationConfirm">Параметры для подключения</param>
    /// <returns></returns>
    ValueTask<CResult<bool>> ConfirmRegistrationAsync(CRegistrationConfirm registrationConfirm);
}