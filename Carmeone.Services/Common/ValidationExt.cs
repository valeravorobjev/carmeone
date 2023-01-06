using Carmeone.Db.Entities.Base;
using Carmeone.Services.Models;
using EmailValidation;

namespace Carmeone.Services.Common;

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
    public static Validation Validate(this Registration registration)
    {
        Validation validation = new Validation();
        
        AccountRole[] validRoles = { AccountRole.Company, AccountRole.User };
        
        if (!validRoles.Contains(registration.AccountRole))
            validation.FieldErrors.Add(nameof(registration.AccountRole), StatusCode.RoleInvalid);
        
        if (string.IsNullOrEmpty(registration.Email))
            validation.FieldErrors.Add(nameof(registration.Email), StatusCode.FieldEmpty);
        
        if (!EmailValidator.Validate(registration.Email))
            validation.FieldErrors.Add(nameof(registration.Email), StatusCode.EmailInvalid);
        
        if (string.IsNullOrEmpty(registration.Password))
            validation.FieldErrors.Add(nameof(registration.Password), StatusCode.FieldEmpty);
        
        if (string.IsNullOrEmpty(registration.ConfirmPassword))
            validation.FieldErrors.Add(nameof(registration.ConfirmPassword), StatusCode.FieldEmpty);
        
        if (registration.Password != registration.ConfirmPassword)
            validation.FieldErrors.Add(nameof(registration.Password), StatusCode.PasswordNotEqualConfirm);

        return validation;

    }

    /// <summary>
    /// Валидатор модели подтверждения регистрации
    /// </summary>
    /// <param name="registrationConfirm">Модель подтверждения регистрации</param>
    /// <returns></returns>
    public static Validation Validate(this RegistrationConfirm registrationConfirm)
    {
        Validation validation = new Validation();

        return validation;
    }
}