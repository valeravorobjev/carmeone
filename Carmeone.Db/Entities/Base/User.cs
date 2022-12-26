namespace Carmeone.Db.Entities.Base;

public abstract class User
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public string Id { get; set; } = null!;

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
}