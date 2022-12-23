namespace Carmeone.Db.Entities;

/// <summary>
/// Пользователь
/// </summary>
public class User
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
    /// Фамилия
    /// </summary>
    public string FirstName { get; set; }
    /// <summary>
    /// Имя
    /// </summary>
    public string LastName { get; set; }
    /// <summary>
    /// Отчество
    /// </summary>
    public string MiddleName { get; set; }
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
    /// Дата рождения
    /// </summary>
    public DateTime DateBirth { get; set; }
}