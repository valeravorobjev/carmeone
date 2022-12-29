namespace Carmeone.Db.Entities;

/// <summary>
/// Пользователь
/// </summary>
public abstract class User
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public string UserId { get; set; } = null!;

    /// <summary>
    /// Аватар (картинка)
    /// </summary>
    public string Avatar { get; set; } = null!;

    /// <summary>
    /// Телефон
    /// </summary>
    public string Phone { get; set; } = null!;

    /// <summary>
    /// Адрес
    /// </summary>
    public string Address { get; set; } = null!;

    /// <summary>
    /// Описание
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Дата регистрации
    /// </summary>
    public DateTime RegistrationDate { get; set; }
    
    /// <summary>
    /// Связь с таблицей Account
    /// </summary>
    public Account Account { get; set; }
}