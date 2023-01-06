namespace Carmeone.Services.Models;

/// <summary>
/// Статический класс с перечнем кодов ошибок.
/// </summary>
public enum StatusCode
{
    /// <summary>
    /// Успешно
    /// </summary>
    Ok,

    /// <summary>
    /// Поле пустое
    /// </summary>
    FieldEmpty,

    /// <summary>
    /// Почтовый адрес имеет не верный формат
    /// </summary>
    EmailInvalid,
    
    /// <summary>
    /// Не верная роль
    /// </summary>
    RoleInvalid,

    /// <summary>
    /// Пароль не совпадает с подтверждением
    /// </summary>
    PasswordNotEqualConfirm,
    
    /// <summary>
    /// Модель не валидна
    /// </summary>
    ModelInvalid,
    
    /// <summary>
    /// Значение не найдено
    /// </summary>
    NotFound,
    
    /// <summary>
    /// Логин или пароль не верные
    /// </summary>
    LoginOrPasswordIncorrect,

    /// <summary>
    /// Пользователь с таким логином уже существует
    /// </summary>
    UserAllreadyExists,

    /// <summary>
    /// Внутренняя ошибка сервера
    /// </summary>
    InternalError
}