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
    /// Связь с таблицей пользователя-компании
    /// </summary>
    public CompanyUser? CompanyUser { get; set; }
    
    /// <summary>
    /// Связь с таблицей обычного пользователя
    /// </summary>
    public IndividualUser? IndividualUser { get; set; }
    
    public Account Account { get; set; }
    
    /// <summary>
    /// Связь многие ко многим с таблицей публикаций
    /// </summary>
    public ICollection<Publication> Publications { get; set; }
    /// <summary>
    /// Связь многие ко многим с таблицей публикаций
    /// </summary>
    public ICollection<UserPublication> UserPublications { get; set; }
}