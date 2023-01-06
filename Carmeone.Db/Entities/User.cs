namespace Carmeone.Db.Entities;

/// <summary>
/// Пользователь
/// </summary>
public class User
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Аватар (картинка)
    /// </summary>
    public string? Avatar { get; set; }

    /// <summary>
    /// Телефон
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// Город
    /// </summary>
    public string? Sity { get; set; }

    /// <summary>
    /// Адрес
    /// </summary>
    public string? Address { get; set; }
    
    /// <summary>
    /// Фамилия
    /// </summary>
    public string? FirstName { get; set; }

    /// <summary>
    /// Имя
    /// </summary>
    public string? LastName { get; set; }

    /// <summary>
    /// Отчество
    /// </summary>
    public string? MiddleName { get; set; }

    /// <summary>
    /// Дата рождения
    /// </summary>
    public DateTime? DateBirth { get; set; }

    /// <summary>
    /// Описание
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Связь с таблицей аккаунта
    /// </summary>
    public Account Account { get; set; } = null!;

    /// <summary>
    /// Связь многие ко многим с таблицей публикаций
    /// </summary>
    public ICollection<Publication>? Publications { get; set; }

    /// <summary>
    /// Связь многие ко многим с таблицей публикаций
    /// </summary>
    public ICollection<UserPublication>? UserPublications { get; set; }
}