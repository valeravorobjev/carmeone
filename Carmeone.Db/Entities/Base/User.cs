namespace Carmeone.Db.Entities.Base;

public abstract class User
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public string Id { get; set; }
    /// <summary>
    /// Аватар (картинка)
    /// </summary>
    public string Avatar { get; set; }
    /// <summary>
    /// Телефон
    /// </summary>
    public string Phone { get; set; }
    /// <summary>
    /// Адрес
    /// </summary>
    public string Address { get; set; }
    /// <summary>
    /// Описание
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Дата регистрации
    /// </summary>
    public DateTime RegistrationDate { get; set; }
}