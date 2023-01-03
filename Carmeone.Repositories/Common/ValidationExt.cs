using Carmeone.Repositories.Models;
using EmailValidation;

namespace Carmeone.Repositories.Common;

/// <summary>
/// Валидации и проверки моделей
/// </summary>
public static class ValidationExt
{
    /// <summary>
    /// Валидация модели регистрации нового пользователя
    /// </summary>
    /// <param name="registration">Модель регистрации</param>
    /// <returns></returns>
    public static CValidation Validate(this CRegistration registration)
    {
        CValidation validation = new CValidation();
        
        if (string.IsNullOrEmpty(registration.Email))
            validation.FieldErrors.Add(nameof(registration.Email), CCodes.FieldEmpty);
        
        if (EmailValidator.Validate(registration.Email))
            validation.FieldErrors.Add(nameof(registration.Email), CCodes.EmailInvalid);
        
        if (string.IsNullOrEmpty(registration.Password))
            validation.FieldErrors.Add(nameof(registration.Password), CCodes.FieldEmpty);
        
        if (string.IsNullOrEmpty(registration.ConfirmPassword))
            validation.FieldErrors.Add(nameof(registration.ConfirmPassword), CCodes.FieldEmpty);
        
        if (registration.Password != registration.ConfirmPassword)
            validation.FieldErrors.Add(nameof(registration.Password), CCodes.PasswordNotEqualConfirm);

        return validation;

    }
}