namespace Carmeone.Db.Entities;

/// <summary>
/// Пользователь
/// </summary>
public class IndividualUser
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid IndividualUserId { get; set; }

    /// <summary>
    /// Фамилия
    /// </summary>
    public string FirstName { get; set; } = null!;

    /// <summary>
    /// Имя
    /// </summary>
    public string LastName { get; set; } = null!;

    /// <summary>
    /// Отчество
    /// </summary>
    public string MiddleName { get; set; } = null!;

    /// <summary>
    /// Дата рождения
    /// </summary>
    public DateTime? DateBirth { get; set; }
    
    /// <summary>
    /// Пользователь
    /// </summary>
    public User? User { get; set; }
}