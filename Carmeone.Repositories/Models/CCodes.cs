namespace Carmeone.Repositories.Models;

/// <summary>
/// Статический класс с перечнем кодов ошибок.
/// </summary>
public static class CCodes
{
    /// <summary>
    /// Успешно
    /// </summary>
    public const string Ok = "OK";

    /// <summary>
    /// Поле пустое
    /// </summary>
    public const string FieldEmpty= "FIELD_EMPTY";

    /// <summary>
    /// Почтовый адрес имеет не верный формат
    /// </summary>
    public const string EmailInvalid = "INVALID_EMAIL";

    /// <summary>
    /// Пароль не совпадает с подтверждением
    /// </summary>
    public const string PasswordNotEqualConfirm = "PASSWORD_NOT_EQUAL_CONFIRM";
    
    /// <summary>
    /// Модель не валидна
    /// </summary>
    public const string ModelInvalid= "MODEL_INVALID";
    
    /// <summary>
    /// Значение не найдено
    /// </summary>
    public const string NotFound = "NOT_FOUND";

    /// <summary>
    /// Пользователь с таким логином уже существует
    /// </summary>
    public const string UserAllreadyExists = "USER_ALLREADY_EXISTS";

    /// <summary>
    /// Внутренняя ошибка сервера
    /// </summary>
    public const string InternalServerError = "INTERNAL_SERVER_ERROR";
}