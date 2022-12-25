using Carmeone.Db.Entities.Base;

namespace Carmeone.Db.Entities;

/// <summary>
/// Пользователь
/// </summary>
public class IndividualUser: User
{
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
    /// Дата рождения
    /// </summary>
    public DateTime DateBirth { get; set; }
}