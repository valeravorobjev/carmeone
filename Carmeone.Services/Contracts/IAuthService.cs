using Carmeone.Services.Models;

namespace Carmeone.Services.Contracts;

/// <summary>
/// Работа с аккаунтом пользователя
/// </summary>
public interface IAuthService
{
    /// <summary>
    /// Регистрация нового пользователя
    /// </summary>
    /// <param name="registration">Регистрация</param>
    /// <returns></returns>
    ValueTask<CarmeoneResult<string>> RegAsync(Registration registration);

    /// <summary>
    /// Подтвердение регистрации пользователя
    /// </summary>
    /// <param name="registrationConfirm">Параметры для подключения</param>
    /// <returns></returns>
    ValueTask<CarmeoneResult<bool>> RegConfirmAsync(RegistrationConfirm registrationConfirm);

    /// <summary>
    /// Авторизация
    /// </summary>
    /// <param name="login">Авторизация</param>
    /// <returns></returns>
    ValueTask<CarmeoneResult<bool>> LoginAsync(Login login);
}