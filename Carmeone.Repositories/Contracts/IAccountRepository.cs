using Carmeone.Repositories.Models;

namespace Carmeone.Repositories.Contracts;

/// <summary>
/// Работа с аккаунтом пользователя
/// </summary>
public interface IAccountRepository
{
    ValueTask<bool> RegistrationAsync(DtoRegistration dtoRegistration);
}