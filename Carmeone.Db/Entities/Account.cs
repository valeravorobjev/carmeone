namespace Carmeone.Db.Entities;

/// <summary>
/// Аккаунт пользователя
/// </summary>
public class Account
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public string UserId { get; set; }
    /// <summary>
    /// Логин пользователя
    /// </summary>
    public string Login { get; set; }
    /// <summary>
    /// Пароль (зашифрован)
    /// </summary>
    public string Password { get; set; }
    /// <summary>
    /// Соль, первичная. К этой соли подмешивается специальный код.
    /// </summary>
    public int Salt { get; set; }
    /// <summary>
    /// Почтовый адрес
    /// </summary>
    public string Email { get; set; }
    /// <summary>
    /// Роль аккаунта пользователя
    /// </summary>
    public AccountRole AccountRole { get; set; }
}